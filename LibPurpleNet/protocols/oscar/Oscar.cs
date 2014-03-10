using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPurpleNet.protocols.oscar
{
    public enum OscarDisconnectReason
    {
	    OSCAR_DISCONNECT_DONE, /* not considered an error */
	    OSCAR_DISCONNECT_LOCAL_CLOSED, /* peer connections only, not considered an error */
	    OSCAR_DISCONNECT_REMOTE_CLOSED,
	    OSCAR_DISCONNECT_REMOTE_REFUSED, /* peer connections only */
	    OSCAR_DISCONNECT_LOST_CONNECTION,
	    OSCAR_DISCONNECT_INVALID_DATA,
	    OSCAR_DISCONNECT_COULD_NOT_CONNECT,
	    OSCAR_DISCONNECT_RETRYING /* peer connections only */
    } 

    public struct aim_authresp_info
    {
	    public string bn;
        public UInt16 errorcode;
        public string errorurl;
        public UInt16 regstatus;
        public string email;
        public string bosip;
        public UInt16 cookielen;
        public uint cookie;
        public string chpassurl;
        public aim_clientrelease latestrelease;
        public aim_clientrelease latestbeta;
    }

    public struct aim_chat_exchangeinfo
    {
        public UInt16 number;
        public UInt16 flags;
        public string name;
        public string charset1;
        public string lang1;
        public string charset2;
        public string lang2;
    }

    public struct aim_chat_roominfo
    {
        public UInt16 exchange;
        public string name;
        public uint namelen;
        public UInt16 instance;
    }

    public struct aim_clientrelease
    {
        public string name;
        public UInt32 build;
        public string url;
        public string info;
    }

    public struct aim_emailinfo
    {
        public uint cookie16;
        public uint cookie8;
        public string url;
        public UInt16 nummsgs;
        public uint unread;
        public string domain;
        public UInt16 flag;
        public struct Next
        {
            public aim_emailinfo next;
        }
    }

    public struct aim_icbmparameters
    {
        public UInt16 maxchan;
        public UInt32 flags; /* AIM_IMPARAM_FLAG_ */
        public UInt16 maxmsglen; /* message size that you will accept */
        public UInt16 maxsenderwarn; /* this and below are *10 (999=99.9%) */
        public UInt16 maxrecverwarn;
        public UInt32 minmsginterval; /* in milliseconds? */
    }

    public struct aim_icq_info
    {
        public UInt16 reqid;

	    /* simple */
        public UInt32 uin;

	    /* general and "home" information (0x00c8) */
        public string nick;
        public string first;
        public string last;
        public string email;
        public string homecity;
        public string homestate;
        public string homephone;
        public string homefax;
        public string homeaddr;
        public string mobile;
        public string homezip;
        public UInt16 homecountry;
    /*	uint timezone;
	    uint hideemail; */

	    /* personal (0x00dc) */
        public uint age;
        public uint unknown;
        public uint gender;
        public string personalwebpage;
        public UInt16 birthyear;
        public uint birthmonth;
        public uint birthday;
        public uint language1;
        public uint language2;
        public uint language3;

	    /* work (0x00d2) */
        public string workcity;
        public string workstate;
        public string workphone;
        public string workfax;
        public string workaddr;
        public string workzip;
        public UInt16 workcountry;
        public string workcompany;
        public string workdivision;
        public string workposition;
        public string workwebpage;

	    /* additional personal information (0x00e6) */
        public string info;

	    /* email (0x00eb) */
        public UInt16 numaddresses;
        public string email2;

	    /* status note info */
        public uint[] icbm_cookie;
        public string status_note_title;

        public bool for_auth_request;
        public string auth_request_reason;
    }

    public struct aim_incomingim_ch1_args
    {
        public UInt32 icbmflags; /* some flags apply only to ->msg, not all mpmsg */
        public long timestamp; /* Only set for offline messages */

        public string msg;

        /* Only provided if AIM_IMFLAGS_HASICON is set */
        public long iconstamp;
        public UInt32 iconlen;
        public UInt16 iconsum;
    }

    public struct aim_invite_priv
    {
        public string bn;
        public string roomname;
        public UInt16 exchange;
        public UInt16 instance;
    }

    public struct aim_modsnac_t
    {
        public UInt16 family;
        public UInt16 subtype;
        public UInt16 flags;
        public UInt32 id;
    }

    struct aim_module_t
    {
	    public UInt16 family;
	    public UInt16 version;
	    public UInt16 toolid;
	    public UInt16 toolversion;
        public UInt16 flags;
	    public string name;
	    //int (*snachandler)(OscarData *od, FlapConnection *conn, struct aim_module_s *mod, FlapFrame *rx, aim_modsnac_t *snac, ByteStream *bs);
	    //void (*shutdown)(OscarData *od, struct aim_module_s *mod);
	    public IntPtr priv;
        public struct Next
        {
            public aim_module_t next;
        }
    }

    public struct aim_redirect_data
    {
        public UInt16 group;
        public string ip;
        public UInt16 cookielen;
        public uint cookie;
        public string ssl_cert_cn;
        public uint use_ssl;
        public struct chat
        {
            public UInt16 exchange;
            public string room;
            public UInt16 instance;
        }
    }

    public struct aim_sendimext_args
    {
	    /* These are _required_ */
        public string destbn;
        public UInt32 flags; /* often 0 */

        public string msg;
        public UInt32 msglen;

	    /* Only used if AIM_IMFLAGS_HASICON is set */
        public UInt32 iconlen;
        public long iconstamp;
        public UInt32 iconsum;

        public UInt16 featureslen;
        public uint features;

        public UInt16 charset;
    }

    public struct aim_snac_t 
    {
        public UInt32 id;
        public UInt16 family;
        public UInt16 type;
        public UInt16 flags;
        public IntPtr data;
        public DateTime issuetime;
        public struct Next
        {
            public aim_snac_t next;
        }
    }

    public struct aim_ssi_item
    {
        public string name;
        public UInt16 gid;
        public UInt16 bid;
        public UInt16 type;
        public List<string> data;
        public struct Next
        {
            public aim_ssi_item next;
        }
    }

    public struct aim_ssi_tmp
    {
        public UInt16 action;
	    public UInt16 ack;
        public string name;
	    public aim_ssi_item item;
        public struct Next
        {
            public aim_ssi_tmp next;
        }
    }

    public struct aim_tlv_t
    {
	    public UInt16 type;
        public UInt16 length;
        public uint value;
    }

    public struct aim_userinfo_t
    {
	    public string bn;
	    public UInt16 warnlevel; /* evil percent * 10 (999 = 99.9%) */
	    public UInt16 idletime; /* in seconds */
	    public UInt16 flags;
	    public UInt32 createtime; /* time_t */
	    public UInt32 membersince; /* time_t */
	    public UInt32 onlinesince; /* time_t */
	    public UInt32 sessionlen;  /* in seconds */
	    public UInt64 capabilities;
	    public struct icqinfo
        {
		    public UInt32 status;
		    public UInt32 ipaddr;
		    public uint[] crap; /* until we figure it out... */
	    }
        public UInt32 present;

	    public uint iconcsumtype;
	    public UInt16 iconcsumlen;
	    public uint iconcsum;

	    public string info;
	    public string info_encoding;
	    public UInt16 info_len;

	    public string status;
	    public string status_encoding;
	    public UInt16 status_len;

	    public string itmsurl;
	    public string itmsurl_encoding;
	    public UInt16 itmsurl_len;

	    public string away;
	    public string away_encoding;
	    public UInt16 away_len;

	    public struct Next
        {
            public aim_userinfo_t next;
        }
    }

    public struct buddyinfo
    {
        public bool typingnot;
        public Int32 ipaddr;

        public ulong ico_me_len;
        public ulong ico_me_csum;
        public DateTime ico_me_time;
        public bool ico_informed;

        public ulong ico_len;
        public ulong ico_csum;
        public DateTime ico_time;
        public bool ico_need;
        public bool ico_sent;
    }

    public struct ByteStream
    {
        public uint data;
        public UInt16 len;
        public UInt16 offset;
    }

    public struct chat_connection
    {
        public string name;
        public string show; /* AOL did something funny to us */
        public UInt16 exchange;
        public UInt16 instance;
        public FlapConnection conn;
        public int id;
        public PurpleConnection gc;
        public PurpleConversation conv;
        public int maxlen;
        public int maxvis;
    }

    public struct create_room
    {
        public string name;
        public int exchange;
    }

    struct chatsnacinfo 
    {
	    UInt16 exchange;
	    char[] name;
	    UInt16 instance;
    }

    public struct FlapConnection
    {
        public OscarData od;
        public bool connected;
        public long lastactivity;
        public uint destroy_timeout;
        public OscarDisconnectReason disconnect_reason;
        public string error_message;
        public UInt16 disconnect_code;

        public PurpleProxyConnectData connect_data;
        public UInt16 cookielen;
        public uint cookie;
        public IntPtr new_conn_data;

        public int fd;
        public PurpleSslConnection gsc;
        public uint[] header;
        public Int32 header_received;
        public FlapFrame buffer_incoming;
        public PurpleCircBuffer buffer_outgoing;
        public uint watcher_incoming;
        public uint watcher_outgoing;

        public UInt16 type;
        public UInt16 subtype;
        public UInt16 seqnum_out;
        public UInt16 seqnum_in;
        public List<string> groups;
        public List<string> rateclasses;
        public rateclass default_rateclass;
        public Hashtable rateclass_members;

        public Queue queued_snacs;
        public Queue queued_lowpriority_snacs;
        public uint queued_timeout;

        public IntPtr internalData;
    }

    public struct FlapFrame
    {
        public uint channel;
        public UInt16 seqnum;
        public ByteStream data;        /* payload stream */
    }

    struct IcbmArgsCh2
    {
	    public UInt16 status;
	    public char[] cookie;
	    public UInt64 type; /* One of the OSCAR_CAPABILITY_ constants */
	    public string proxyip;
	    public string clientip;
	    public string verifiedip;
	    public UInt16 port;
	    public bool use_proxy;
	    UInt16 errorcode;
	    public string msg; /* invite message or file description */
	    UInt16 msglen;
	    public string encoding;
	    public string language;
	    UInt16 requestnumber;
        //union {
        //    struct {
        //        guint32 checksum;
        //        guint32 length;
        //        time_t timestamp;
        //        guint8 *icon;
        //    } icon;
        //    struct {
        //        struct aim_chat_roominfo roominfo;
        //    } chat;
        //    struct {
        //        guint8 msgtype;
        //        const char *msg;
        //    } rtfmsg;
        //    struct {
        //        guint16 subtype;
        //        guint16 totfiles;
        //        guint32 totsize;
        //        char *filename;
        //    } sendfile;
        //} info;
	    public IntPtr destructor; /* used internally only */
    }

    public struct IcbmCookie
    {
        public char[] cookie;
        public int type;
        public IntPtr data;
        public long addtime;
        public struct Next
        {
            public IcbmCookie next;
        }
    }

    public struct name_data
    {
        public PurpleConnection gc;
        public string name;
        public string nick;
    }

    public struct oscar_ask_directim_data
    {
        public OscarData od;
        public string who;
    }

    public struct OscarData
    {
        public PurpleUtilFetchUrlData url_data;

        public bool iconconnecting;
        public bool set_icon;

        public List<string> create_rooms;

        public bool conf;
        public bool reqemail;
        public bool setemail;
        public string email;
        public bool setnick;
        public string newformatting;
        public bool chpass;
        public string oldp;
        public string newp;

        public List<string> oscar_chats;
        public Hashtable buddyinfo;
        public List<string> requesticon;

        bool use_ssl;
        public bool icq;
        public uint getblisttimer;
        
        public struct rights
        {
            public uint maxwatchers;
            public uint maxbuddies;
            public uint maxgroups;
            public uint maxpermits;
            public uint maxdenies;
            public uint maxsiglen;
            public uint maxawaymsglen;
        }

        public PurpleConnection gc;

        public IntPtr modlistv;

        public IntPtr[] snac_hash;
        public UInt32 snacid_next;

        public IcbmCookie msgcookies;
        public List<string> icq_info;

        public aim_authresp_info authinfo;
        public aim_emailinfo emailinfo;

        public struct locate
        {
		    public aim_userinfo_t userinfo;
	    }

        public struct bos
        {
            public bool have_rights;
        }

        public struct ssi
        {
		    public bool received_data;
		    public UInt16 numitems;
		    public aim_ssi_item official;
		    public aim_ssi_item local;
		    public aim_ssi_tmp pending;
		    public long timestamp;
		    public bool waiting_for_ack;
		    public bool in_transaction;
	    }

        public Hashtable handlerlist;

        public List<string> oscar_connections;
        public UInt16 default_port;

        public List<string> peer_connections;
    }
    public struct QueuedSnac
    {
        public UInt16 family;
        public UInt16 subtype;
        public FlapFrame frame;
    }

    public struct rateclass 
    {
	    UInt16 classid;
	    UInt32 windowsize;
	    UInt32 clear;
	    UInt32 alert;
	    UInt32 limit;
	    UInt32 disconnect;
	    UInt32 current;
	    UInt32 max;
	    uint dropping_snacs;

	    TimeSpan last; /**< The time when we last sent a SNAC of this rate class. */
    }

    public struct userinfo_node
    {
        public string bn;
        public struct Next
        {
            public userinfo_node next;
        }
    }

    public class Oscar
    {
    }
}
