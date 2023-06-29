namespace Fig.Api.SettingVerification.Sdk;

public class VerificationResult
{
    public bool Success { get; set; }

    public string Message { get; set; }

    public DateTime ExecutionTime { get; } = DateTime.UtcNow;

    public List<string> Logs { get; set; } = new();

    public static VerificationResult IncorrectParameters(string? message = null)
    {
        return new VerificationResult
        {
            Success = false,
            Message = $"Incorrect parameters were provided. {message}"
        };
    }

    public void AddLog(string message)
    {
        Logs.Add(message);
    }
}