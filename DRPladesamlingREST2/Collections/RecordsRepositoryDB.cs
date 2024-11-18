namespace DRPladesamlingREST2.Collections
{
    public class RecordsRepositoryDB
    {

        private readonly RecordDBContext _context;

        public RecordsRepositoryDB(RecordDBContext context)
        {
            _context = context;
        }

        public int Count => _context.Records.Count();

        public List<Record> GetAll()
        {
            List<Record> records = _context.Records.ToList();

            return records;
        }


    }
}
