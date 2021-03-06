﻿namespace Krypton.Toolkit.Suite.Extended.Language.Model
{
    /// <summary>The chosen language for buttons.</summary>
    public enum Language
    {
        /// <summary>The Czech definition.</summary>
        CZECH,
        /// <summary>The English definition.</summary>
        ENGLISH,
        /// <summary>The Français definition.</summary>
        FRANÇAIS,
        /// <summary>The Deutsch definition.</summary>
        DEUTSCH,
        /// <summary>The Slovakian definition.</summary>
        SLOVAKIAN,
        /// <summary>The Español definition.</summary>
        ESPAÑOL,
        /// <summary>A custom language definition.</summary>
        CUSTOM
    }

    /// <summary>The type of buttons.</summary>
    public enum ButtonType
    {
        /// <summary>Ok button only.</summary>
        OK,
        /// <summary>A ok/cancel button.</summary>
        OKCANCEL,
        /// <summary>A yes/no button.</summary>
        YESNO,
        /// <summary>A yes/no/cancel button.</summary>
        YESNOCANCEL,
        /// <summary>A retry/cancel button.</summary>
        RETRYCANCEL,
        /// <summary>A abort/retry/ignore button.</summary>
        ABORTRETRYIGNORE
    }
}