using System;
namespace WebSocketHandler.WebSocketOp
{
    public class WebSocketOption
    {
        WebSocketOption()
        {
            KeepAliveInterval = TimeSpan.FromSeconds(120);
            ReceiveBufferSize = 4 * 1024;

        }
            public TimeSpan KeepAliveInterval { get; set; }
            public int ReceiveBufferSize { get; set; }

       public  static WebSocketOption DefaultOption =new WebSocketOption();
    }


}
