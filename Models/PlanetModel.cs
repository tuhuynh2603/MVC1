using System.Net.Mime;

namespace MVC1.Models
{
    public class PlanetModel
    {
        public int Id {get;set;}
        public string? Name { get; set; }
        public string? VnName {get;set;}
        public string? Content {get;set;}
    }
}