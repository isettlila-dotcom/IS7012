public class Candidate
{
	public int Id { get; set; }
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public decimal TargetSalary { get; set; }
	public DateTime? StartDate { get; set; }

	public string Email { get; set; } = string.Empty;
	public string PhoneNumber { get; set; } = string.Empty;

	public Company? Company { get; set; }
	public JobTitle JobTitle { get; set; } = null!;
	public Industry Industry { get; set; } = null!;
}
