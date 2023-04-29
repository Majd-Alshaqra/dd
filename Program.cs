using cities;
var builder = WebApplication.CreateBuilder(args);

//Minimal API :
var app = builder.Build();
app.Urls.Add("http://localhost:5000");
var Cars = new List<City>{
    new City{
        Id = 1,
        city = "London",
        Temperature = 11,
        High = 200,
        Low = 200,
    },
    new City{
        Id = 1,
        city = "Gaza",
        Temperature = 22,
        High = 200,
        Low = 200,
    },
    new City{
        Id = 1,
        city = "Dubai",
        Temperature = 33,
        High = 200,
        Low = 200,
    },
    //kkkkk
};
app.MapGet("/api/cities/{id}", (string Id) =>City.cities.FirstOrDefault(c => 
c.Id == Id)); // Get Car By Id
// Update cities
app.MapPut("/api/cities/{id}", (string id, City updatedCar) => 
{
var carIndex = City.cities.FindIndex(c => c.Id == Id);
City.cities[carIndex] = updatedCar;
return "Updated!";
});

app.Run();