using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
///     Assembler class responsible for converting between GreetDeveloperRequest and Developer entities.
/// </summary>
public static class DeveloperAssembler
{
    /// <summary>
    /// Converts a <see cref="Developer"/> entity to a <see cref="GreetDeveloperResponse"/> resource.
    /// </summary>
    /// <param name="request">The <see cref="Developer"/> entity to convert.</param>
    /// <returns>A <see cref="GreetDeveloperResponse"/> resource representing the given entity</returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request is null 
            || string.IsNullOrWhiteSpace(request.FirstName)
            || string.IsNullOrWhiteSpace(request.LastName))
            return null;
        return new Developer(
            firstName: request.FirstName,
            lastName: request.LastName);
    }
}