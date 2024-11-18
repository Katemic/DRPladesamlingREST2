namespace DRPladesamlingREST2.Collections
{
    public class RecordsRepositoryList
    {
        private readonly RecordDBContext _context;

        public RecordsRepositoryList(RecordDBContext context)
        {
            _context = context;
        }
    }
}
