public class Industry
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public List<Candidate> Candidates { get; set; } = new List<Candidate>();
    public List<Company> Companies { get; set; } = new List<Company>();
}