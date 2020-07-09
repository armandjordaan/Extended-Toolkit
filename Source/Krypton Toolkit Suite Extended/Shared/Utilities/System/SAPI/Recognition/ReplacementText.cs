using System.Runtime.InteropServices;

namespace Krypton.Toolkit.Suite.Extended.Utilities.System.Recognition
{
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ReplacementText
	{
		private DisplayAttributes _displayAttributes;

		private string _text;

		private int _wordIndex;

		private int _countOfWords;

		public DisplayAttributes DisplayAttributes => _displayAttributes;

		public string Text => _text;

		public int FirstWordIndex => _wordIndex;

		public int CountOfWords => _countOfWords;

		internal ReplacementText(DisplayAttributes displayAttributes, string text, int wordIndex, int countOfWords)
		{
			_displayAttributes = displayAttributes;
			_text = text;
			_wordIndex = wordIndex;
			_countOfWords = countOfWords;
		}
	}
}
