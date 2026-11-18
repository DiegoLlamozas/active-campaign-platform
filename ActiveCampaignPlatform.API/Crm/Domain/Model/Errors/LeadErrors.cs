using ActiveCampaignPlatform.API.Shared.Domain.Model.Errors;

namespace ActiveCampaignPlatform.API.Crm.Domain.Model.Errors;

/// <summary>
///     Catalog of domain errors for the CRM bounded context.
/// </summary>
/// <remarks>Author: Your Full Name</remarks>
public static class LeadErrors
{
    /// <summary>A lead with the same first name and last name is already registered (409).</summary>
    public static readonly Error DuplicateFirstNameAndLastName = Error.Conflict(
        "Crm.DuplicateFirstNameAndLastName",
        "A lead with the same first name and last name already exists.");

    /// <summary>The lead data breaks a business rule (400).</summary>
    /// <param name="detail">The specific rule that was broken.</param>
    public static Error InvalidLeadData(string detail) =>
        Error.Validation("Crm.InvalidLeadData", detail);
}