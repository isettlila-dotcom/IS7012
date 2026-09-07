public class Company
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PositionName { get; set; } = string.Empty;
    public decimal MinimumSalary { get; set; }
    public decimal MaximumSalary { get; set; }
    public DateTime? StartDate { get; set; }
    public string Location { get; set; } = string.Empty;

    public string Website { get; set; } = string.Empty;
    public bool IsRemote { get; set; }

    public Industry Industry { get; set; } = null!;
    public List<Candidate> Candidates { get; set; } = new List<Candidate>();
}