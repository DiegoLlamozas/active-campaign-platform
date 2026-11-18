namespace ActiveCampaignPlatform.API.Crm.Domain.Model.ValueObjects;

public sealed record LastName
{
    public LastName(string value)
    {
        Value = NameRules.Validate(value, "Last name");
    }
    
    public string Value { get; }
    
    public override string ToString() => Value;
}