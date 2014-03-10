using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPurpleNet
{
    public struct PurpleConversation
    {
	    //public PurpleConversationType type;  /**< The type of conversation.          */

	    public PurpleAccount account;       /**< The user using this conversation.  */


	    public string name;                 /**< The name of the conversation.      */
	    public string title;                /**< The window title.                  */

	    public bool logging;           /**< The status of logging.             */

	    public List<string> logs;                /**< This conversation's logs           */

        //union
        //{
        //    PurpleConvIm   *im;       /**< IM-specific data.                  */
        //    PurpleConvChat *chat;     /**< Chat-specific data.                */
        //    void *misc;             /**< Misc. data.                        */

        //} u;

	    //public PurpleConversationUiOps *ui_ops;           /**< UI-specific operations. */
	    public IntPtr ui_data;                           /**< UI-specific data.       */

	    public Hashtable data;                        /**< Plugin-specific data.   */

	    public PurpleConnectionFlags features; /**< The supported features */
	    public List<string> message_history;         /**< Message history, as a GList of PurpleConvMessage's */
    }

    class Conversation
    {
    }
}
