using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPurpleNet
{
    public struct PurpleAccount
    {
        public string username;
        public string alias;
        public string password;
        public string user_info;

        public string buddy_icon_path;

        public bool remember_pass;

        public string protocol_id;

        public PurpleConnection gc;
        public bool disconnecting;

        public Hashtable settings;
        public Hashtable ui_settings;

        public PurpleProxyInfo proxy_info;

        public List<string> permit;
        public List<string> deny;
        public PurplePrivacyType perm_deny;

        public List<string> status_types;

        public PurplePresence presence;
        public PurpleLog system_log;

        public IntPtr ui_data;
        //public PurpleAcountRegistration registration_cb;
        public IntPtr registration_cb_user_data;

        public IntPtr priv;
    }

    public class Account
    {
    }
}
