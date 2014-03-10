using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPurpleNet
{
    public struct PurpleUtilFetchUrlData
    {
	    //public PurpleUtilFetchUrlCallback callback;
	    public IntPtr user_data;

	    public struct website
	    {
		    public string user;
		    public string passwd;
		    public string address;
		    public int port;
		    public string page;
	    }

	    public string url;
	    public int num_times_redirected;
	    public bool full;
	    public string user_agent;
	    public bool http11;
	    public string request;
	    public UInt32 request_written;
	    public bool include_headers;

	    public bool is_ssl;
	    public PurpleSslConnection ssl_connection;
	    public PurpleProxyConnectData connect_data;
	    public int fd;
	    public uint inpa;

	    public bool got_headers;
	    public bool has_explicit_data_len;
	    public string webdata;
	    public UInt32 len;
	    public ulong data_len;
	    public Int32 max_len;
	    public bool chunked;
	    public PurpleAccount account;
    }

    class Util
    {
    }
}
