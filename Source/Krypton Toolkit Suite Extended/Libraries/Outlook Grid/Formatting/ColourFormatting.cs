﻿//--------------------------------------------------------------------------------
// Copyright (C) 2013-2015 JDH Software - <support@jdhsoftware.com>
//
// This program is provided to you under the terms of the Microsoft Public
// License (Ms-PL) as published at https://kryptonoutlookgrid.codeplex.com/license
//
// Visit http://www.jdhsoftware.com and follow @jdhsoftware on Twitter
//
//--------------------------------------------------------------------------------

using System;
using System.Drawing;
using static Krypton.Toolkit.Suite.Extended.Outlook.Grid.ColourHelper;

namespace Krypton.Toolkit.Suite.Extended.Outlook.Grid
{
    /// <summary>
    /// Color Formatting class : all the magic !
    /// </summary>
    public static class ColourFormatting
    {
        /// <summary>
        /// Returns the percentage value for a Bar formatting.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static double ConvertBar(double value, double min, double max)
        {
            double percent;
            if (min == max)
            {
                percent = 1.0;
            }
            else
            {
                //Min can be different from 0 
                percent = (value - min) / (max - min);
            }
            return percent;
        }

        /// <summary>
        /// Returns the color for a 2scale color formatting.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="par">The 2color parameters.</param>
        /// <returns></returns>
        public static Color ConvertTwoRange(double value, double min, double max, TwoColoursParams par)
        {
            HSVColour A = ColourToHSV(par.MinimumColour);
            HSVColour B = ColourToHSV(par.MaximumColour);

            //Ratio
            double percent;
            if (min == max)
            {
                percent = 1.0;
            }
            else
            {
                //Min can be different from 0 
                percent = (value - min) / (max - min);
            }
            return Color.FromArgb((int)Math.Round(par.MinimumColour.A + (par.MaximumColour.A - par.MinimumColour.A) * percent), (int)Math.Round(par.MinimumColour.R + (par.MaximumColour.R - par.MinimumColour.R) * percent), (int)Math.Round(par.MinimumColour.G + (par.MaximumColour.G - par.MinimumColour.G) * percent), (int)Math.Round(par.MinimumColour.B + (par.MaximumColour.B - par.MinimumColour.B) * percent));
        }

        /// <summary>
        /// Returns the color for a 3scale color formatting.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="par">The 3color parameters.</param>
        /// <returns></returns>
        public static Color ConvertThreeRange(double value, double min, double max, ThreeColoursParams par)
        {
            HSVColour A = ColourToHSV(par.MinimumColour);
            HSVColour B = ColourToHSV(par.MaximumColour);
            HSVColour C = ColourToHSV(par.MediumColour);

            //Ratio
            double percent;
            if (min == max)
            {
                percent = 1.0;
            }
            else
            {
                //Min can be different from 0 
                percent = (value - min) / (max - min);
            }

            if (percent == 0.5)
            {
                return par.MediumColour;
            }
            else if (percent <= 0.5)
            {
                return Color.FromArgb((int)Math.Round(par.MinimumColour.A + (par.MediumColour.A - par.MinimumColour.A) * percent), (int)Math.Round(par.MinimumColour.R + (par.MediumColour.R - par.MinimumColour.R) * percent), (int)Math.Round(par.MinimumColour.G + (par.MediumColour.G - par.MinimumColour.G) * percent), (int)Math.Round(par.MinimumColour.B + (par.MediumColour.B - par.MinimumColour.B) * percent));
            }
            else
            {
                return Color.FromArgb((int)Math.Round(par.MediumColour.A + (par.MaximumColour.A - par.MediumColour.A) * percent), (int)Math.Round(par.MediumColour.R + (par.MaximumColour.R - par.MediumColour.R) * percent), (int)Math.Round(par.MediumColour.G + (par.MaximumColour.G - par.MediumColour.G) * percent), (int)Math.Round(par.MediumColour.B + (par.MaximumColour.B - par.MediumColour.B) * percent));
            }
        }

        private static HSVColour ColourToHSV(Color colour)
        {
            int max = Math.Max(colour.R, Math.Max(colour.G, colour.B));
            int min = Math.Min(colour.R, Math.Min(colour.G, colour.B));

            double hue = colour.GetHue();
            double saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            double value = max / 255d;

            return new HSVColour((float)hue, (float)saturation, (float)value);
        }

        private static Color ColourFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }
        /// <summary>
        /// Interpolate colors 0.0 - 1.0        
        /// </summary>        
        private static Color Interpolate(double percent, params Color[] colours)
        {
            int left = (int)Math.Floor(percent * (colours.Length - 1));
            int right = (int)Math.Ceiling(percent * (colours.Length - 1));
            Color colorLeft = colours[left];
            Color colorRight = colours[right];

            double step = 1.0 / (colours.Length - 1);
            double percentRight = (percent - (left * step)) / step;
            double percentLeft = 1.0 - percentRight;
            return Color.FromArgb((byte)(colorLeft.A * percentLeft + colorRight.A * percentRight), (byte)(colorLeft.R * percentLeft + colorRight.R * percentRight), (byte)(colorLeft.G * percentLeft + colorRight.G * percentRight), (byte)(colorLeft.B * percentLeft + colorRight.B * percentRight));
        }
    }
}