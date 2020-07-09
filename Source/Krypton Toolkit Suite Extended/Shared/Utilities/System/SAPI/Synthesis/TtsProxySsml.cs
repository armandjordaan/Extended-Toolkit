﻿using System;
using System.Collections.Generic;

namespace Krypton.Toolkit.Suite.Extended.Utilities.System.Synthesis
{
    internal class TtsProxySsml : ITtsEngineProxy
    {
        private TtsEngineSsml _ssmlEngine;

        private ITtsEngineSite _site;

        internal override AlphabetType EngineAlphabet => AlphabetType.Ipa;

        internal TtsProxySsml(TtsEngineSsml ssmlEngine, ITtsEngineSite site, int lcid)
            : base(lcid)
        {
            _ssmlEngine = ssmlEngine;
            _site = site;
        }

        internal override IntPtr GetOutputFormat(IntPtr targetFormat)
        {
            return _ssmlEngine.GetOutputFormat(SpeakOutputFormat.WaveFormat, targetFormat);
        }

        internal override void AddLexicon(Uri lexicon, string mediaType)
        {
            _ssmlEngine.AddLexicon(lexicon, mediaType, _site);
        }

        internal override void RemoveLexicon(Uri lexicon)
        {
            _ssmlEngine.RemoveLexicon(lexicon, _site);
        }

        internal override void Speak(List<TextFragment> frags, byte[] wfx)
        {
            GCHandle gCHandle = GCHandle.Alloc(wfx, GCHandleType.Pinned);
            try
            {
                IntPtr waveHeader = gCHandle.AddrOfPinnedObject();
                _ssmlEngine.Speak(frags.ToArray(), waveHeader, _site);
            }
            finally
            {
                gCHandle.Free();
            }
        }

        internal override char[] ConvertPhonemes(char[] phones, AlphabetType alphabet)
        {
            if (alphabet == AlphabetType.Ipa)
            {
                return phones;
            }
            return _alphabetConverter.SapiToIpa(phones);
        }

        internal override void ReleaseInterface()
        {
        }
    }
}