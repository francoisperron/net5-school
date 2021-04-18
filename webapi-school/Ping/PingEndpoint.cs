namespace School.Ping
{
    public class PingEndpoint
    {
        public PingResponse Get()
        {
            return new() {Alive = true};
        }
    }
}