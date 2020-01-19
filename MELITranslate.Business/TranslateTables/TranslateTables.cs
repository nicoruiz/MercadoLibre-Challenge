using System.Collections.Generic;

namespace MELITranslate.Business
{
    public class TranslateTables
    {
        #region Binary 2 Morse table
        public static Dictionary<string, string> Bin2Morse = new Dictionary<string, string>
        {
            { "10", BinaryConstants.DOT },
            { "11", BinaryConstants.DASH },
            { "01", BinaryConstants.LETTER_SPACE },
            { "00", BinaryConstants.WORD_SPACE }
        };
        #endregion

        #region Text 2 Morse table
        public static Dictionary<string, string> Text2Morse = new Dictionary<string, string>
        {
            { "A", MorseConstants.A },
            { "B", MorseConstants.B },
            { "C", MorseConstants.C },
            { "D", MorseConstants.D },
            { "E", MorseConstants.E },
            { "F", MorseConstants.F },
            { "G", MorseConstants.G },
            { "H", MorseConstants.H },
            { "I", MorseConstants.I },
            { "J", MorseConstants.J },
            { "K", MorseConstants.K },
            { "L", MorseConstants.L },
            { "M", MorseConstants.M },
            { "N", MorseConstants.N },
            { "O", MorseConstants.O },
            { "P", MorseConstants.P },
            { "Q", MorseConstants.Q },
            { "R", MorseConstants.R },
            { "S", MorseConstants.S },
            { "T", MorseConstants.T },
            { "U", MorseConstants.U },
            { "V", MorseConstants.V },
            { "W", MorseConstants.W },
            { "X", MorseConstants.X },
            { "Y", MorseConstants.Y },
            { "Z", MorseConstants.Z },
            { "0", MorseConstants.ZERO },
            { "1", MorseConstants.ONE },
            { "2", MorseConstants.TWO },
            { "3", MorseConstants.THREE},
            { "4", MorseConstants.FOUR },
            { "5", MorseConstants.FIVE },
            { "6", MorseConstants.SIX },
            { "7", MorseConstants.SEVEN },
            { "8", MorseConstants.EIGHT },
            { "9", MorseConstants.NINE },
            { ".", MorseConstants.FULLSTOP }
        };
        #endregion

        #region Morse 2 Text table
        public static Dictionary<string, string> Morse2Text = new Dictionary<string, string>
        {
            { MorseConstants.A, "A" },
            { MorseConstants.B, "B" },
            { MorseConstants.C, "C" },
            { MorseConstants.D, "D" },
            { MorseConstants.E, "E" },
            { MorseConstants.F, "F" },
            { MorseConstants.G, "G" },
            { MorseConstants.H, "H" },
            { MorseConstants.I, "I" },
            { MorseConstants.J, "J" },
            { MorseConstants.K, "K" },
            { MorseConstants.L, "L" },
            { MorseConstants.M, "M" },
            { MorseConstants.N, "N" },
            { MorseConstants.O, "O" },
            { MorseConstants.P, "P" },
            { MorseConstants.Q, "Q" },
            { MorseConstants.R, "R" },
            { MorseConstants.S, "S" },
            { MorseConstants.T, "T" },
            { MorseConstants.U, "U" },
            { MorseConstants.V, "V" },
            { MorseConstants.W, "W" },
            { MorseConstants.X, "X" },
            { MorseConstants.Y, "Y" },
            { MorseConstants.Z, "Z" },
            { MorseConstants.ZERO, "0" },
            { MorseConstants.ONE, "1" },
            { MorseConstants.TWO, "2" },
            { MorseConstants.THREE, "3" },
            { MorseConstants.FOUR, "4" },
            { MorseConstants.FIVE, "5" },
            { MorseConstants.SIX, "6" },
            { MorseConstants.SEVEN, "7" },
            { MorseConstants.EIGHT, "8" },
            { MorseConstants.NINE, "9" },
            { MorseConstants.FULLSTOP, "." }
        };
        #endregion
    }
}
