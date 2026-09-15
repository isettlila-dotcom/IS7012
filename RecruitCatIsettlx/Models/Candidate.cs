using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Candidate
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [DisplayName("First Name")]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    [DisplayName("Last Name")]
    public string LastName { get; set; } = string.Empty;

    [Range(0, 1000000)]
    [DisplayName("Target Salary")]
    public decimal TargetSalary { get; set; }

    [DataType(DataType.Date)]
    [DisplayName("Start Date")]
    public DateTime? StartDate { get; set; }

    [Required]
    [StringLength(100)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    [Phone]
    [DisplayName("Phone Number")]
    public string PhoneNumber { get; set; } = string.Empty;

    [DisplayName("Company")]
    public int? CompanyId { get; set; }

    public Company? Company { get; set; }

    [DisplayName("Job Title")]
    public int JobTitleId { get; set; }

    public JobTitle? JobTitle { get; set; }

    [DisplayName("Industry")]
    public int IndustryId { get; set; }

    public Industry? Industry { get; set; }
}