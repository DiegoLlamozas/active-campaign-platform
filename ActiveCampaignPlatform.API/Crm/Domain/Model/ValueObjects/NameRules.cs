namespace ActiveCampaignPlatform.API.Crm.Domain.Model.ValueObjects;

/// <summary>
///     Validation rules shared by the lead name value objects.
/// </summary>
/// <remarks>Author: Your Full Name</remarks>
internal static class NameRules
{
    public const int MinLength = 4;
    public const int MaxLength = 40;

    /// <summary>
    ///     Validates a name and returns it trimmed.
    /// </summary>
    /// <param name="value">The raw name.</param>
    /// <param name="label">The label used in the error message.</param>
    /// <returns>The trimmed name.</returns>
    /// <exception cref="ArgumentException">Null, empty, or outside 4-40 characters.</exception>
    public static string Validate(string? value, string label)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException($"{label} cannot be null or empty.", nameof(value));

        var trimmed = value.Trim();
        if (trimmed.Length is < MinLength or > MaxLength)
            throw new ArgumentException(
                $"{label} must be between {MinLength} and {MaxLength} characters.", nameof(value));

        return trimmed;
    }
}