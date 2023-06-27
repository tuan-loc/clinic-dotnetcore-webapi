namespace ClinicDotNet.MailServices.Models
{
	public class EmailVerificationResult
	{
		public bool IsSucceed { get; set; } = false;
		public bool IsValid { get; set; } = false;
		public object Details { get; set; }
	}
}
