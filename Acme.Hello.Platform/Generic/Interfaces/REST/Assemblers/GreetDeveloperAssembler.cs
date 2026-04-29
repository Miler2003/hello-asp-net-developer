using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
///     Assembler class responsible for converting between Developer entities and GreetDeveloperResponse resources.
/// </summary>
public class GreetDeveloperAssembler
{
    /// <summary>
    /// Converts a Developer entity into a GreetDeveloperResponse. If the entity is
    /// it returns a response with a generic welcome message. Otherwise, it constr
    /// </summary>
    /// <param name="entity">The Developer entity to convert into GreetDeveloperResponse</param>
    /// <returns>A GreetDeveloperResponse containing the developer's ID, fill name</returns>
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? entity)
    {
        if (entity is null || entity.IsAnyNameEmpty())
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET Developer");
        return new GreetDeveloperResponse(entity.Id, entity.GetFullName(),
            $"Congrats {entity.GetFullName()}! You are an ASP.NET Developer");
    }
}