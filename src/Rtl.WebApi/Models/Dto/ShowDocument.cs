using Nest;

namespace Rtl.WebApi.Models.Dto
{
    public class ShowDocument
    {
        [Number(Name = "id")]
        public int Id { get; set; }

        [Text(Name = "language")]
        public string? Language { get; set; }
        public Network Network { get; set; } = new Network();
        public Links Links { get; set; }

        [Text(Name = "version")]
        public string? Version { get; set; }

        [Number(Name = "updated")]
        public int Updated { get; set; }

        [Text(Name = "url")]
        public string? Url { get; set; }

        [Text(Name = "name")]
        public string? Name { get; set; }

        [Number(Name = "averageRuntime")]
        public int AverageRuntime { get; set; }

        [Text(Name = "officialSite")]
        public string? OfficialSite { get; set; }

        [Date(Name = "Ended")]
        public DateTime? Ended { get; set; }

        [Date(Name = "timestamp")]
        public DateTime? Timestamp { get; set; }

        [Text(Name = "type")]
        public string? Type { get; set; }

        [Text(Name = "summary")]
        public string? Summary { get; set; }

        [PropertyName("schedule")]
        public Schedule? Schedule { get; set; }

        [Text(Name = "status")] 
        public string? Status { get; set; }

        [PropertyName("rating")]
        public Rating? Rating { get; set; }

        [PropertyName("externals")]
        public Externals? Externals { get; set; }

        [PropertyName("image")]
        public Image? Image { get; set; }

        [Number(Name = "weight")]
        public int? Weight { get; set; }

        [Number(Name = "runtime")]
        public int? Runtime { get; set; }

        [PropertyName("genres")]
        public string[]? Genres { get; set; }

        [Nested]
        [PropertyName("cast")]
        public Cast[] Cast { get; set; } = new Cast[0];

        [Text(Name = "premiered")] 
        public string? Premiered { get; set; }
    }

    public class Network
    {
        [Number(Name="id")]
        public int Id { get; set; }

        [Text(Name = "officialSite")]
        public string? OfficialSite { get; set; }

        [PropertyName("country")]
        public Country? Country { get; set; }

        [Text(Name = "name")]
        public string? Name { get; set; }
    }

    public class Country
    {
        [Text(Name = "timezone")]
        public string Timezone { get; set; } = String.Empty;

        [Text(Name = "code")]
        public string Code { get; set; } = String.Empty;

        [Text(Name = "name")]
        public string Name { get; set; } = String.Empty;
    }


    public class Links
    {
        [PropertyName("previousepisode")]
        public Previousepisode? Previousepisode { get; set; }

        [PropertyName("self")]
        public Self? Self { get; set; }
    }

    public class Previousepisode
    {
        [Text(Name = "href")]
        public string Href { get; set; } = String.Empty;
    }

    public class Self
    {
        [Text(Name = "href")]
        public string Href { get; set; } = String.Empty;
    }

    public class Schedule
    {
        [Text(Name = "time")]
        public string? Time { get; set; }

        [PropertyName("days")]
        public string[]? Days { get; set; }
    }

    public class Rating
    {
        [FloatRange]
        public float Average { get; set; }
    }

    public class Externals
    {
        [Text(Name = "imdb")]
        public string? Imdb { get; set; }

        [Number(Name = "thetvdb")]
        public int Thetvdb { get; set; }

        [Number(Name = "tvrage")]
        public int Tvrage { get; set; }
    }

    public class Image
    {
        [Text(Name = "original")]
        public string? Original { get; set; }

        [Text(Name = "medium")]
        public string? Medium { get; set; }
    }

    public class Cast
    {
        [PropertyName("character")]
        public Character Character { get; set; } = new Character();

        [PropertyName("person")]
        public Person Person { get; set; } = new Person();

        [Boolean]
        public bool Voice { get; set; }

        [Boolean]
        public bool Self { get; set; }
    }

    public class Character
    {
        [Number(Name="id")]
        public int id { get; set; }

        [PropertyName("links")]
        public Links? Links { get; set; }

        [Text(Name = "url")]
        public string? Url { get; set; }

        [Text(Name = "name")]
        public string? Name { get; set; }

        [PropertyName("image")]
        public Image? Image { get; set; }
    }


    public class Person
    {
        [Number(Name = "id")]
        public int Id { get; set; }

        [Text(Name = "deathday")]
        public string? Deathday { get; set; }

        [Text(Name = "gender")]
        public string? Gender { get; set; }

        [PropertyName("image")]
        public Image? Image { get; set; }

        [Date(Name = "birthday")]
        public DateTime? Birthday { get; set; }
        public Links? Links { get; set; }
        
        [Number(Name = "updated")]
        public int Updated { get; set; }

        [Text(Name = "url")]
        public string? Url { get; set; }

        [Text(Name = "name")]
        public string? Name { get; set; }

        [PropertyName("country")]
        public Country? Country { get; set; }
    }



}

