namespace Emes.Core.Service;

public class CreateEntityInput
{
    /// <summary>
    ///
    /// </summary>
    /// <example>student</example>
    public string TableName { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <example>Student</example>
    public string EntityName { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <example>AutoIncrementEntity</example>
    public string BaseClassName { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <example>Magic.Application</example>
    public string Position { get; set; }

    /// <summary>
    ///
    /// </summary>
    public string ConfigId { get; set; }
}