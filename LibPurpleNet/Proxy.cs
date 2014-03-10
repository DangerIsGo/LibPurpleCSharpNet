using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPurpleNet
{
    public enum PurpleProxyType
    {
	    PURPLE_PROXY_USE_GLOBAL = -1,  /**< Use the global proxy information. */
	    PURPLE_PROXY_NONE = 0,         /**< No proxy.                         */
	    PURPLE_PROXY_HTTP,             /**< HTTP proxy.                       */
	    PURPLE_PROXY_SOCKS4,           /**< SOCKS 4 proxy.                    */
	    PURPLE_PROXY_SOCKS5,           /**< SOCKS 5 proxy.                    */
	    PURPLE_PROXY_USE_ENVVAR,       /**< Use environmental settings.       */
	    PURPLE_PROXY_TOR               /**< Use a Tor proxy (SOCKS 5 really)  */
    }

    public struct PurpleProxyConnectData
    {
        public IntPtr handle;
        //public PurpleProxyConnectFunction connect_cb;
        public IntPtr data;
        public string host;
        public int port;
        public int fd;
        public int socket_type;
        public uint inpa;
        public PurpleProxyInfo gpi;
        public PurpleDnsQueryData query_data;

        /**
         * This contains alternating length/char* values.  The char*
         * values need to be freed when removed from the linked list.
         */
        public List<string> hosts;

        public struct Child
        {
            public PurpleProxyConnectData child;
        }

        /*
         * All of the following variables are used when establishing a
         * connection through a proxy.
         */
        public string write_buffer;
        public UInt32 write_buf_len;
        public UInt32 written_len;
        //public PurpleInputFunction read_cb;
        public string read_buffer;
        public UInt32 read_buf_len;
        public UInt32 read_len;
        public PurpleAccount account;
    }

    public struct PurpleProxyInfo
    {
	    public PurpleProxyType type;   /**< The proxy type.  */

        public string host;           /**< The host.        */
	    public int port;           /**< The port number. */
	    public string username;       /**< The username.    */
        public string password;       /**< The password.    */

    }

    class Proxy
    {
    }
}
