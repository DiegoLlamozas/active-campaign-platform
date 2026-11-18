namespace ActiveCampaignPlatform.API.Crm.Domain.Model.ValueObjects;

public sealed record FirstName
{
    public FirstName(string value)
    {
        Value = NameRules.Validate(value, "First name");
    }
    
    public string Value { get; }
    
    public override string ToString() => Value;
}