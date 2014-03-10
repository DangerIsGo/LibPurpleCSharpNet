using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPurpleNet
{
    public struct PurpleSslConnection
    {
        /** Hostname to which the SSL connection will be made */
        public string host;
        /** Port to connect to */
        public int port;
        /** Data to pass to PurpleSslConnection::connect_cb() */
        public IntPtr connect_cb_data;
        /** Callback triggered once the SSL handshake is complete */
        //public PurpleSslInputFunction connect_cb;
        /** Callback triggered if there is an error during connection */
        //public PurpleSslErrorFunction error_cb;
        /** Data passed to PurpleSslConnection::recv_cb() */
        public IntPtr recv_cb_data;
        /** User-defined callback executed when the SSL connection receives data */
        //public PurpleSslInputFunction recv_cb;

        /** File descriptor used to refer to the socket */
        public int fd;
        /** Glib event source ID; used to refer to the received data callback
         * in the glib eventloop */
        public uint inpa;
        /** Data related to the underlying TCP connection */
        public PurpleProxyConnectData connect_data;

        /** Internal connection data managed by the SSL backend (GnuTLS/LibNSS/whatever) */
        public IntPtr private_data;

        /** Verifier to use in authenticating the peer */
        //public PurpleCertificateVerifier verifier;
    }

    class SslConn
    {
    }
}
