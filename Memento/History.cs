using System.Collections;

namespace DesignPatterns.Memento
{
    /// <summary>
    ///     The Caretaker
    /// </summary>
    public class History
    {
        private readonly ArrayList _states = new ArrayList(); // List of Mementos

        public void Push(EditorState state) // Push Mementos in the shell
        {
            this._states.Add(state);
        }

        public EditorState Pop() // Get the Mementos from the shell
        {
            var lastIndex = this._states.Count - 1;
            var lastState = this._states[lastIndex];

            this._states.Remove(lastState);

            return lastState as EditorState;
        }
    }
}