namespace MutDood.Storage.Interfaces.Core.Metadata
{
    /// <summary>
    /// Database Identifier
    /// </summary>
    public class Did
    {
        /// <summary>
        /// Database location ID
        /// </summary>
        public byte[] Dli { get; set; }
        /// <summary>
        /// Database unique identifier
        /// </summary>
        public byte[] Duid { get; set; }
    }
}