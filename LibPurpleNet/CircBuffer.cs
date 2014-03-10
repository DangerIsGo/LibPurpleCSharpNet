using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPurpleNet
{
    public struct PurpleCircBuffer
    {

        /** A pointer to the starting address of our chunk of memory. */
        public string buffer;

        /** The incremental amount to increase this buffer by when
         *  the buffer is not big enough to hold incoming data, in bytes. */
        public UInt32 growsize;

        /** The length of this buffer, in bytes. */
        public UInt32 buflen;

        /** The number of bytes of this buffer that contain unread data. */
        public UInt32 bufused;

        /** A pointer to the next byte where new incoming data is
         *  buffered to. */
        public string inptr;

        /** A pointer to the next byte of buffered data that should be
         *  read by the consumer. */
        public string outptr;

    }
    class CircBuffer
    {
    }
}
