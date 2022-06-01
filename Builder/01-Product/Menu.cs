namespace Builder{
    public class Menu{
        private Dictionary<string, string> _parts = new Dictionary<string, string>();
        public void Add(string part) => _parts.Add(part, part);
        public override string ToString() => String.Join(", ", _parts.Values);
    }
}
