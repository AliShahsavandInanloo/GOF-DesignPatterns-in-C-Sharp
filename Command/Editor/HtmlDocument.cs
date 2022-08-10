namespace DesignPatterns.Command.Editor
{
    public class HtmlDocument
    {
        public string Content { get; set; }

        public void MakeBold()
        {
            this.Content = "<b>" + this.Content + "</b>";
        }
    }
}