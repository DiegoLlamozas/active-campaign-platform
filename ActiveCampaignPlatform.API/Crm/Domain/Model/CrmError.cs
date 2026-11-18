namespace ActiveCampaignPlatform.API.Crm.Domain.Model;

/// <summary>
///     Error codes of the CRM bounded context, used to select the HTTP status code.
/// </summary>
/// <remarks>Author: Your Full Name</remarks>
public enum CrmError
{
    None,
    DuplicateFirstNameAndLastName,
    InvalidLeadData
}