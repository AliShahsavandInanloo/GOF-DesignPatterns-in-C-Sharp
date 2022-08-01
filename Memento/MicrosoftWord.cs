namespace DesignPatterns.Memento
{
    public class MicrosoftWord // The Originator class
    {
        public string Content  { get; set; }
        public string FontName { get; set; }
        public int    FontSize { get; set; }

        public DocumentState CreateDocumentState()
        {
            return new DocumentState(this.Content, this.FontName, this.FontSize);
        }

        public void RestoreDocumentState(DocumentState state)
        {
            this.Content  = state.Content;
            this.FontName = state.FontName;
            this.FontSize = state.FontSize;
        }
    }
}