using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPurpleNet
{
    public struct PurplePresence
    {
        //PurplePresenceContext context;

        public bool idle;
        public DateTime idle_time;
        public DateTime login_time;

        public List<string> statuses;
        public Hashtable status_table;

        public struct u
        {
            public PurpleAccount account;

            public struct chat
            {
                //public PurpleConversation conv;
                public string user;
            }

            public struct buddy
            {
                public PurpleAccount account;
                public string name;
                //public PurpleBuddy buddy;
            }
        }
    }

    class Status
    {
    }
}
