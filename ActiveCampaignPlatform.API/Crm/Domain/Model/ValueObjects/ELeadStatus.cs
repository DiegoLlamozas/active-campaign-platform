namespace ActiveCampaignPlatform.API.Crm.Domain.Model.ValueObjects;

/// <summary>
///     Represents the status of a lead in the ActiveCampaign CRM.
/// </summary>
public enum ELeadStatus
{
    Open = 1,
    Contacted = 2,
    MeetingSet = 3,
    Qualified = 4,
    Customer = 5,
    OpportunityLost = 6,
    Unqualified = 7,
    InactiveCustomer = 8
}