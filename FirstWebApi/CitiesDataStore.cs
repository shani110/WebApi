 using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
       // public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                     Id = 1,
                     Name = "Gilgit",
                     Description = "The one with most beautiful places.",
                     PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 1,
                             Name = "Naltar",
                             Description = "The attractive and beautiful place of pakistan" },
                          new PointOfInterestDto() {
                             Id = 2,
                             Name = "Barmas Nala",
                             Description = "Beautifull water fall" },
                     }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Nagar",
                    Description = "The which has 3 mighty peaks, rakaposhi, golden peak and deeran peak",
                    PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 3,
                             Name = "Rakaposhi View Point",
                             Description = "The best place to visit in summers to see rakaposhi" },
                          new PointOfInterestDto() {
                             Id = 4,
                             Name = "Daiter Valley",
                             Description = "The very beautifull place of district nagar to where you can see beautifl greenery and lakes" },
                     }
                },
                new CityDto()
                {
                    Id= 3,
                    Name = "skerdo",
                    Description = "The one with international airport",
                    PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 5,
                             Name = "cold desert",
                             Description = "beutifull desert to visit" },
                          new PointOfInterestDto() {
                             Id = 6,
                             Name = "shangerilla lake",
                             Description = "bautifull heart lake to see" },
                     }
                }
            };

        }

    }
}
