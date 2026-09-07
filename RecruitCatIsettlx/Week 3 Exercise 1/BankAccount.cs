public class BankAccount
{
	public int Id { get; set; }
	public string AccountNumber { get; set; } = string.Empty;
	public decimal CurrentBalance { get; set; }
	public string AccountName { get; set; } = string.Empty;
	public bool IsActive { get; set; }
	public DateTime DateOpened { get; set; }

	public AccountHolder AccountHolder { get; set; } = null!;
}
