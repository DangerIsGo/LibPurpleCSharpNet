using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPurpleNet
{
    public enum PurpleLogType
    {
	    PURPLE_LOG_IM,
	    PURPLE_LOG_CHAT,
	    PURPLE_LOG_SYSTEM
    }

    public struct PurpleLogLogger
    {
        string name;
	    string id;


    }

    public struct PurpleLog
    {
        public PurpleLogType type;
        public string name;
        public struct Account
        {
            public PurpleAccount account;
        }
        
        //public PurpleConversation conv;
        public DateTime time;

        //public PurpleLogLogger logger;

        //public void logger_data;

        public struct tm { }
    }

    public class Log
    {
        public void foo()
        {

        }
    }
}
