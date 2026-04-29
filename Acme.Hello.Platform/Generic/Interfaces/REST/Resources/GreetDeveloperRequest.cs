namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
///     Request to greet a developer, containing their first and last name.
/// </summary>
/// <param name="FirsName">The developer's first name, may be null</param>
/// <param name="LastName">The developer's last name, may be null</param>
public record GreetDeveloperRequest(string? FirstName, string? LastName);