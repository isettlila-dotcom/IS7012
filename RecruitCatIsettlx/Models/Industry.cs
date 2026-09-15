using System.ComponentModel.DataAnnotations;

public class Industry
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    public List<Candidate> Candidates { get; set; } = new List<Candidate>();

    public List<Company> Companies { get; set; } = new List<Company>();
}