using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    public class BrowsHistory
    {
        private List<string> Urls { get; } = new List<string>();

        public void Push(string url)
        {
            this.Urls.Add(url);
        }

        public string Pop()
        {
            var lastIndex = this.Urls.Count - 1;
            var lastUrl   = this.Urls[lastIndex];

            this.Urls.Remove(lastUrl);

            return lastUrl;
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator<string>
        {
            private int _index;

            public ListIterator(BrowsHistory history)
            {
                this.History = history;
            }

            public BrowsHistory History { get; }

            public bool HastNext()
            {
                return this._index < this.History.Urls.Count;
            }

            public string Current()
            {
                return this.History.Urls[this._index];
            }

            public void Next()
            {
                this._index++;
            }
        }
    }
}