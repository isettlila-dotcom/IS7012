public class JobTitle
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal MinimumSalary { get; set; }
    public decimal MaximumSalary { get; set; }

    public string Description { get; set; } = string.Empty;

    public List<Candidate> Candidates { get; set; } = new List<Candidate>();
}