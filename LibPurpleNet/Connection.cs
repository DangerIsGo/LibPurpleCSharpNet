using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPurpleNet
{
    public struct PurpleConnection
    {
        //PurplePlugin* prpl;            /**< The protocol plugin.               */
        //PurpleConnectionFlags flags;   /**< Connection flags.                  */

        //PurpleConnectionState state;   /**< The connection state.              */

        public struct Account
        {
            public PurpleAccount account;        /**< The account being connected to.    */
        }
        public string password;              /**< The password used.                 */
        public int inpa;                    /**< The input watcher.                 */

        public List<string> buddy_chats;         /**< A list of active chats
	                                  (#PurpleConversation structs of type
	                                  //#PURPLE_CONV_TYPE_CHAT).           */
        public IntPtr proto_data;            /**< Protocol-specific data.            */

        public string display_name;          /**< How you appear to other people.    */
        public uint keepalive;             /**< Keep-alive.                        */

        /** Wants to Die state.  This is set when the user chooses to log out, or
         * when the protocol is disconnected and should not be automatically
         * reconnected (incorrect password, etc.).  prpls should rely on
         * purple_connection_error_reason() to set this for them rather than
         * setting it themselves.
         * @see purple_connection_error_is_fatal
         */
        public bool wants_to_die;

        public uint disconnect_timeout;    /**< Timer used for nasty stack tricks  */
        public DateTime last_received;        /**< When we last received a packet. Set by the
					  prpl to avoid sending unneeded keepalives */
    }

    public enum PurpleConnectionError
    {
	    /** There was an error sending or receiving on the network socket, or
	     *  there was some protocol error (such as the server sending malformed
	     *  data).
	     */
	    PURPLE_CONNECTION_ERROR_NETWORK_ERROR = 0,
	    /** The username supplied was not valid. */
	    PURPLE_CONNECTION_ERROR_INVALID_USERNAME = 1,
	    /** The username, password or some other credential was incorrect.  Use
	     *  #PURPLE_CONNECTION_ERROR_INVALID_USERNAME instead if the username
	     *  is known to be invalid.
	     */
	    PURPLE_CONNECTION_ERROR_AUTHENTICATION_FAILED = 2,
	    /** libpurple doesn't speak any of the authentication methods the
	     *  server offered.
	     */
	    PURPLE_CONNECTION_ERROR_AUTHENTICATION_IMPOSSIBLE = 3,
	    /** libpurple was built without SSL support, and the connection needs
	     *  SSL.
	     */
	    PURPLE_CONNECTION_ERROR_NO_SSL_SUPPORT = 4,
	    /** There was an error negotiating SSL on this connection, or the
	     *  server does not support encryption but an account option was set to
	     *  require it.
	     */
	    PURPLE_CONNECTION_ERROR_ENCRYPTION_ERROR = 5,
	    /** Someone is already connected to the server using the name you are
	     *  trying to connect with.
	     */
	    PURPLE_CONNECTION_ERROR_NAME_IN_USE = 6,

	    /** The username/server/other preference for the account isn't valid.
	     *  For instance, on IRC the username cannot contain white space.
	     *  This reason should not be used for incorrect passwords etc: use
	     *  #PURPLE_CONNECTION_ERROR_AUTHENTICATION_FAILED for that.
	     *
	     *  @todo This reason really shouldn't be necessary.  Usernames and
	     *        other account preferences should be validated when the
	     *        account is created.
	     */
	    PURPLE_CONNECTION_ERROR_INVALID_SETTINGS = 7,

	    /** The server did not provide a SSL certificate. */
	    PURPLE_CONNECTION_ERROR_CERT_NOT_PROVIDED = 8,
	    /** The server's SSL certificate could not be trusted. */
	    PURPLE_CONNECTION_ERROR_CERT_UNTRUSTED = 9,
	    /** The server's SSL certificate has expired. */
	    PURPLE_CONNECTION_ERROR_CERT_EXPIRED = 10,
	    /** The server's SSL certificate is not yet valid. */
	    PURPLE_CONNECTION_ERROR_CERT_NOT_ACTIVATED = 11,
	    /** The server's SSL certificate did not match its hostname. */
	    PURPLE_CONNECTION_ERROR_CERT_HOSTNAME_MISMATCH = 12,
	    /** The server's SSL certificate does not have the expected
	     *  fingerprint.
	     */
	    PURPLE_CONNECTION_ERROR_CERT_FINGERPRINT_MISMATCH = 13,
	    /** The server's SSL certificate is self-signed.  */
	    PURPLE_CONNECTION_ERROR_CERT_SELF_SIGNED = 14,
	    /** There was some other error validating the server's SSL certificate.
	     */
	    PURPLE_CONNECTION_ERROR_CERT_OTHER_ERROR = 15,

	    /** Some other error occurred which fits into none of the other
	     *  categories.
	     */
	    /* purple_connection_error_reason() in connection.c uses the fact that
	     * this is the last member of the enum when sanity-checking; if other
	     * reasons are added after it, the check must be updated.
	     */
	    PURPLE_CONNECTION_ERROR_OTHER_ERROR = 16
    }

    public struct PurpleConnectionErrorInfo
    {
	    /** The type of error. */
	    public PurpleConnectionError type;
	    /** A localised, human-readable description of the error. */
	    public string description;
    }

    public enum PurpleConnectionFlags
    {
	    PURPLE_CONNECTION_HTML       = 0x0001, /**< Connection sends/receives in 'HTML'. */
	    PURPLE_CONNECTION_NO_BGCOLOR = 0x0002, /**< Connection does not send/receive
					               background colors.                  */
	    PURPLE_CONNECTION_AUTO_RESP  = 0x0004,  /**< Send auto responses when away.       */
	    PURPLE_CONNECTION_FORMATTING_WBFO = 0x0008, /**< The text buffer must be formatted as a whole */
	    PURPLE_CONNECTION_NO_NEWLINES = 0x0010, /**< No new lines are allowed in outgoing messages */
	    PURPLE_CONNECTION_NO_FONTSIZE = 0x0020, /**< Connection does not send/receive font sizes */
	    PURPLE_CONNECTION_NO_URLDESC = 0x0040,  /**< Connection does not support descriptions with links */
	    PURPLE_CONNECTION_NO_IMAGES = 0x0080,  /**< Connection does not support sending of images */
	    PURPLE_CONNECTION_ALLOW_CUSTOM_SMILEY = 0x0100, /**< Connection supports sending and receiving custom smileys */
	    PURPLE_CONNECTION_SUPPORT_MOODS = 0x0200, /**< Connection supports setting moods */
	    PURPLE_CONNECTION_SUPPORT_MOOD_MESSAGES = 0x0400 /**< Connection supports setting a message on moods */
    }

    public enum PurpleConnectionState
    {
	    PURPLE_DISCONNECTED = 0, /**< Disconnected. */
	    PURPLE_CONNECTED,        /**< Connected.    */
	    PURPLE_CONNECTING        /**< Connecting.   */
    }

    class Connection
    {
    }
}
