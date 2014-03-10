using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPurpleNet
{
    public struct PurpleDnsQueryData 
    {
	    public string hostname;
	    public int port;
	    //public PurpleDnsQueryConnectFunction callback;
	    public IntPtr data;
	    public uint timeout;
	    public PurpleAccount account;

        //#if defined(PURPLE_DNSQUERY_USE_FORK)
        //    PurpleDnsQueryResolverProcess *resolver;
        //#elif defined _WIN32 /* end PURPLE_DNSQUERY_USE_FORK  */
        //    GThread *resolver;
        //    GSList *hosts;
        //    gchar *error_message;
        //#endif
    }
    class DnsQuery
    {
    }
}
