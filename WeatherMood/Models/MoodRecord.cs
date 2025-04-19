public class MoodRecord
{
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string? Mood { get; set; } // 😊 😐 😞
    public string? WeatherCondition { get; set; }
    public string? Notes { get; set; }
}