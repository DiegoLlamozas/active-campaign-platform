namespace ActiveCampaignPlatform.API.Domain.Model.ValueObjects;

public sealed record ActiveCampaignCustomerId
{
    private const int MaxLength = 255;
    public string Value { get; }
    
    public ActiveCampaignCustomerId(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("ActiveCampaignCustomerId cannot be null or empty.", nameof(value));
        if (value.Length > MaxLength)
            throw new ArgumentException($"ActiveCampaignCustomerId cannot exceed {MaxLength} characters.", nameof(value));

        Value = value;
    }
};