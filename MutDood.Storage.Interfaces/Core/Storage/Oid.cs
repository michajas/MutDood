namespace MutDood.Storage.Interfaces.Core.Storage
{
    public class Oid
    {
        public Oid(byte[] oli, byte[] uid)
        {
            
        }
        /// <summary>
        /// Object location ID
        /// </summary>
        public byte[] Oli { get; set; }
        /// <summary>
        /// Unique id
        /// </summary>
        public byte[] Uid { get; set; }

    }
}
