namespace Rtl.WebApi.Models.Api
{
    public class ShowResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Cast> Cast { get; set; } = new List<Cast>();
    }

    public class Cast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
