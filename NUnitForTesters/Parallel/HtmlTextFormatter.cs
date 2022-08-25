namespace NUnitForTesters.Parallel
{
    public class HtmlTextFormatter
    {
        public string FormatAsBold(string text) => $"<b>{text}</b>";
        public string FormatAsItalic(string text) => $"<i>{text}</i>";

        public string FormatAsSmall(string text) => $"<small>{text}</small>";
        public string FormatAsDeleted(string text) => $"<del>{text}</del>";
        public string FormatAsSubscript(string text) => $"<sub>{text}</sub>";


        public string FormatAsCustomTag(string text, string customTag) => $"<{customTag}>{text}</{customTag}>";

    }
}
