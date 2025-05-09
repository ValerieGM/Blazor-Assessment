namespace BlazorAssessment.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ContactEmail { get; set; }
        public string? Company { get; set; }
        public string? Location { get; set; }
        public decimal Salary { get; set; }
    }
}