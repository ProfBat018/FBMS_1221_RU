using MinimalApi;

public static class CarExtensions
{
    public  static void MapGetCars(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/cars", async () => await GetCarsData());
    }
    
    public static void MapPostCars(this IEndpointRouteBuilder endpoints)
    {
        
        endpoints.MapPost("/addCar", (Car car) =>
        {
            
        });
    }

    private async static Task<string> GetCarsData()
    {
        return "Cars data";
    }
}