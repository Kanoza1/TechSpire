namespace TechSpire.Application.Contracts.Users;

public record UserProfileResponse
(
    string Id,
    string Email,
    string FirstName,
    string LastName
    );
