using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Company
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    [DisplayName("Position Name")]
    public string PositionName { get; set; } = string.Empty;

    [Range(0, 1000000)]
    [DisplayName("Minimum Salary")]
    public decimal MinimumSalary { get; set; }

    [Range(0, 1000000)]
    [DisplayName("Maximum Salary")]
    public decimal MaximumSalary { get; set; }

    [DataType(DataType.Date)]
    [DisplayName("Start Date")]
    public DateTime? StartDate { get; set; }

    [Required]
    [StringLength(200)]
    public string Location { get; set; } = string.Empty;

    [Required]
    [StringLength(200)]
    [Url]
    public string Website { get; set; } = string.Empty;

    [DisplayName("Is Remote")]
    public bool IsRemote { get; set; }

    [DisplayName("Industry")]
    public int IndustryId { get; set; }

    public Industry? Industry { get; set; }

    public List<Candidate> Candidates { get; set; } = new List<Candidate>();
}