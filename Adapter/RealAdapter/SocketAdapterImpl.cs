namespace Design_Pattern.Adapter.RealAdapter
{
    //Use Socket Parent Object
    public class SocketClassAdapterImpl : Socket, ISocketAdapter
    {
        public Volt get120Volt() => GetVolt();
        public Volt get12Volt() => ConvertVolt(GetVolt(), 10);
        public Volt get3Volt() => ConvertVolt(GetVolt(), 40);
    }
    //use Adapter And Inject To the Class
    public class SocketObjectAdapterImpl : ISocketAdapter
    {
        private Socket sock;
        public SocketObjectAdapterImpl() => sock = new Socket();
        public SocketObjectAdapterImpl(Socket _sock) => sock = _sock;

        public Volt get120Volt() => sock.GetVolt();
        public Volt get12Volt() => sock.ConvertVolt(sock.GetVolt(), 10);
        public Volt get3Volt() => sock.ConvertVolt(sock.GetVolt(), 40);

    }

}