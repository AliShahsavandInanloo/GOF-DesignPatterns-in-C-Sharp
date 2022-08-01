namespace DesignPatterns.Memento
{
    /// <summary>
    ///     The Originator
    /// </summary>
    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState() // Create Memento
        {
            return new EditorState(this.Content);
        }

        public void Restore(EditorState state) // Restore Memento
        {
            this.Content = state.Content;
        }
    }
}