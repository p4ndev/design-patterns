using System.Collections.Generic;

namespace MyCollectionExample{
    public class ConcreteAggregate : Aggregate{
        
        private List<object> _items = new List<object>();

        public override Iterator CreateIterator()
            => new ConcreteIterator(this);

        public int Count{ get => _items.Count; }

        public object this[int index]{
            get => _items[index];
            set => _items.Insert(index, value);
        }

    }
}
