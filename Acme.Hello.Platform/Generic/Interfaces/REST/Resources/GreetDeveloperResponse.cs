namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
///     Response type including the developer's ID, FullName and a message.
/// </summary>
/// <remarks>
/// The ID and FullName are nullable to allow for cases where the developer information is not available
///or not relevant to the response. The Message field is required to provide feedback
/// or information about the greeting operation.
/// </remarks>
/// <param name="Id">The developer's ID, if available</param>
/// <param name="FullName">The developer's full name, if available</param>
/// <param name="Message">A message providing feedback or information about the greeting</param>
public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    ///<summary>
    ///Convenience constructor for creating a GreetDeveloperResponse with only a message,
    /// allowing the UD and FullName to be set to null by default.
    /// </summary>
    /// <param name="message">The message to include in the response</param>
    public GreetDeveloperResponse(string message) : this(null, null, message) { }
    
}