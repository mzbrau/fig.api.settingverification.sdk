namespace Fig.Api.SettingVerification.Sdk;

public interface ISettingVerifier
{
    string Name { get; }
    
    string Description { get; }

    VerificationResult RunVerification(params object[] parameters);
}