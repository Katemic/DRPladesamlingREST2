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
            MockData();
        }


        public void MockData()
        {
            Record record1 = new Record("The Dark Side of the Moon", "Pink Floyd", 2950, 1973);
            Record record2 = new Record("The Wall", "Pink Floyd", 3200, 1979);
            Record record3 = new Record("Abbey Road", "The Beatles", 2900, 1969);
            Record record4 = new Record("Sgt. Pepper's Lonely Hearts Club Band", "The Beatles", 2400, 1967);
            Record record5 = new Record("The White Album", "The Beatles", 3000, 1968);

            Add(record1);
            Add(record2);
            Add(record3);
            Add(record4);
            Add(record5);
        }


        public List<Record> GetAll(string? title = null, string? artist = null, int? publicationYear = null)
        {
            List<Record> recordList =  new List<Record>(_records);
            if (title != null)
            {
                recordList = recordList.FindAll(r => r.Title.Contains(title));
            }
            if (artist != null)
            {
                recordList = recordList.FindAll(r => r.Artist.Contains(artist));
            }
            if (publicationYear != null)
            {
                recordList = recordList.FindAll(r => r.PublicationYear == publicationYear);
            }

            return recordList;
        }

        public Record Add(Record record)
        {
            record.Validate();
            _nextId++;
            record.Id = _nextId;
            _records.Add(record);
            return record;
        }


    }
}
