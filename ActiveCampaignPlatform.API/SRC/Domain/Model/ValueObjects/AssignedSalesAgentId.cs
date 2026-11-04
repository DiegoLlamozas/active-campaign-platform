namespace ActiveCampaignPlatform.API.Domain.Model.ValueObjects;

public record AssignedSalesAgentId
{
    public int Value { get; }

    public AssignedSalesAgentId(int value)
    {
        if(value <= 0) 
            throw new ArgumentException("AssignedSalesAgentId must be a positive integer.", nameof(value));

        Value = value;
    }
};