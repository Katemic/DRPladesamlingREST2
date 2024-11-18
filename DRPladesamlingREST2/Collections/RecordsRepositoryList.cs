namespace DRPladesamlingREST2.Collections
{
    public class RecordsRepositoryList
    {
        private List<Record> _records;
        private int _nextId = 0;

        public int Count { get { return _records.Count; } }

        public RecordsRepositoryList()
        {
            _records = new List<Record>();
        }

        public List<Record> GetAll()
        {
            return new List<Record>(_records);
        }
    }
}
