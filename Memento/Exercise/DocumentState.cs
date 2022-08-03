namespace DesignPatterns.Memento
{
    public class DocumentState // The Memento
    {
        public DocumentState(string content, string fontName, int fontSize)
        {
            this.Content  = content;
            this.FontName = fontName;
            this.FontSize = fontSize;
        }

        public string Content  { get; }
        public string FontName { get; }
        public int    FontSize { get; }
    }
}