using MVC1.Models;

namespace MVC1.Services
{
    public class PlanetService : List<PlanetModel>
    {
        public PlanetService()
        {
            Add(new PlanetModel() {Id= 1, Name = "Mercury", VnName = "A", Content="ABC"});
            Add(new PlanetModel() {Id= 2, Name = "Venus", VnName = "B", Content = "DEF"});
            Add(new PlanetModel() {Id= 3, Name = "Venus1", VnName = "B1", Content = "DEF1"});
            Add(new PlanetModel() {Id= 4, Name = "Venus2", VnName = "B2", Content = "DEF2"});
            Add(new PlanetModel() {Id= 5, Name = "Venus3", VnName = "B3", Content = "DEF3"});
            Add(new PlanetModel() {Id= 6, Name = "Venus4", VnName = "B4", Content = "DEF4"});
            Add(new PlanetModel() {Id= 7, Name = "Venus5", VnName = "B5", Content = "DEF5"});
            Add(new PlanetModel() {Id= 8, Name = "Venus6", VnName = "B7", Content = "DEF6"});
            
        }
    }
}