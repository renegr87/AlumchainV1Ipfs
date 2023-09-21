namespace Alumbrado
{
    internal class IpfsClient
    {
        private string v;

        public IpfsClient(string v)
        {
            this.v = v;
        }

        public object FileSystem { get; internal set; }
    }
}