﻿namespace Creek.UI.AutoCompleteMenu
{
    public class Range
    {
        public Range(ITextBoxWrapper targetWrapper)
        {
            TargetWrapper = targetWrapper;
        }

        public ITextBoxWrapper TargetWrapper { get; private set; }
        public int Start { get; set; }
        public int End { get; set; }

        public string Text
        {
            get
            {
                string text = TargetWrapper.Text;

                if (string.IsNullOrEmpty(text))
                    return "";
                if (Start >= text.Length)
                    return "";
                if (End > text.Length)
                    return "";

                return TargetWrapper.Text.Substring(Start, End - Start);
            }

            set
            {
                TargetWrapper.SelectionStart = Start;
                TargetWrapper.SelectionLength = End - Start;
                TargetWrapper.SelectedText = value;
            }
        }
    }
}