namespace DesignPatterns.Memento
{
    /// <summary>
    ///     The Memento
    /// </summary>
    public class EditorState
    {
        public EditorState(string content)
        {
            this.Content = content;
        }

        public string Content { get; }
    }
}