using System.Collections;

namespace DesignPatterns.Memento
{
    public class DocumentHistory // The Caretaker
    {
        private readonly ArrayList _states = new ArrayList();

        public void Push(DocumentState state)
        {
            this._states.Add(state);
        }

        public DocumentState Pop()
        {
            var lastIndex = this._states.Count - 1;
            var lastState = this._states[lastIndex];

            this._states.Remove(lastState);

            return lastState as DocumentState;
        }
    }
}