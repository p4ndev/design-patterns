namespace MyCollectionExample{
    public class ConcreteIterator : Iterator{

        int _current = 0;
        ConcreteAggregate _aggregate;

        public ConcreteIterator(ConcreteAggregate aggregate)
            => _aggregate = aggregate;
        
        public override object First() => _aggregate[0];

        public override object Next() {
            if (_current < (_aggregate.Count - 1))
                return _aggregate[++_current];
            return null;
        }

    }
}
