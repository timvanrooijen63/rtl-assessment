namespace Rtl.WebApi.Models.Shared
{
    public interface IPagination
    {
        int Limit { get; set; }

        int Offset { get; set; }
    }

    public class Pagination : IPagination
    {
        public int Limit { get; set; } = 10;

        public int Offset { get; set; } = 0;

        public Pagination()
        {
        }

        public Pagination(int limit = 10, int offset = 0)
        {
            Limit = limit;
            Offset = offset;
        }
    }

    public class Pagination<T> : Pagination
    {
        public long Total { get; set; }

        public List<T> Results { get; set; }

        public Pagination()
        {
            Results = new List<T>();
        }

        public Pagination(int limit, int offset, List<T> result, int total)
            : base(limit, offset)
        {
            Results = result ?? throw new ArgumentNullException(nameof(result));
            Total = total;
        }

        public Pagination(Pagination pagination, List<T> result, int total)
            : this(pagination.Limit, pagination.Offset, result, total)
        {
          
        }
    }
}
