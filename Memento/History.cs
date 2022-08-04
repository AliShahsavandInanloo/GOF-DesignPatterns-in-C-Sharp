using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    /// <summary>
    ///     The Caretaker
    /// </summary>
    public class History
    {
        private readonly Stack<EditorState>
            _states = new Stack<EditorState>(); // List of Mementos (The Shell)

        public void Push(EditorState state) // Push Mementos in the shell
        {
            this._states.Push(state);
        }

        public EditorState Pop() // Get the Mementos from the shell
        {
            return this._states.Pop();
        }
    }
}