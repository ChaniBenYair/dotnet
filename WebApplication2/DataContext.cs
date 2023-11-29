using System.Formats.Asn1;
using System.Globalization;

namespace WebApplication2
{
    public class DataContext : IDataContext
    {
        public List<Event> EventList { get; set; }

        public DataContext()
        {
            //get data from DB
            using (var reader = new StreamReader("data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                EventList = csv.GetRecords<Event>().ToList();
            }
        }
    }
}
