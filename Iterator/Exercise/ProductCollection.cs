using System.Collections.Generic;

namespace DesignPatterns.Iterator.Exercise
{
    public class ProductCollection
    {
        private List<Product> Products { get; } = new List<Product>();

        public void Push(Product product)
        {
            this.Products.Add(product);
        }

        public IIterator<Product> CreateIterator()
        {
            return new ProductListIterator(this);
        }

        public class ProductListIterator : IIterator<Product>
        {
            private readonly ProductCollection _collection;

            private int _index;

            public ProductListIterator(ProductCollection collection)
            {
                this._collection = collection;
            }


            public bool HasNext()
            {
                return this._index < this._collection.Products.Count;
            }

            public Product Current()
            {
                return this._collection.Products[this._index];
            }

            public void Next()
            {
                this._index++;
            }
        }
    }
}