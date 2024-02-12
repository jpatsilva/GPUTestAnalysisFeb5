namespace GPUTestAnalysisFeb5.Shared.Entity
{
    public class GPU
    {
        public int Id { get; set; }
        public required string? Type { get; set; }
        public required string? Parameter { get; set; }
        public required string? Expression { get; set; }
        public string? Description { get; set; }
    }
}
