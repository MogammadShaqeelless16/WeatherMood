using Microsoft.AspNetCore.Components; 

public class MockWeatherService
{
    private static readonly string[] _conditions = 
        { "☀️ Sunny", "🌧️ Rainy", "⛅ Cloudy", "❄️ Snowy" };
    
    public string GetRandomWeather()
    {
        return _conditions[Random.Shared.Next(_conditions.Length)];
    }
}