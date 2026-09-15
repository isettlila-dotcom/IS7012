using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class JobTitle
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; } = string.Empty;

    [Range(0, 1000000)]
    [DisplayName("Minimum Salary")]
    public decimal MinimumSalary { get; set; }

    [Range(0, 1000000)]
    [DisplayName("Maximum Salary")]
    public decimal MaximumSalary { get; set; }

    [Required]
    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    public List<Candidate> Candidates { get; set; } = new List<Candidate>();
}