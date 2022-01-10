namespace Magicianred.Net.Backend.Domain.Enums
{
    /// <summary>
    /// Registry Event Type Enum
    /// </summary>
    public enum RegistryEventType
    {
        /// <summary>
        /// New entity or publish an existing entity
        /// </summary>
        Insert,
        /// <summary>
        /// Edit data of an existing entity
        /// </summary>
        Update,
        /// <summary>
        /// Remove an entity or unpublish and existing entity
        /// </summary>
        Delete
    }
}
