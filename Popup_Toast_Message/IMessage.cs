using System;
using System.Collections.Generic;
using System.Text;

namespace Popup_Toast_Message
{
    public interface IMessage
    {
        void LongTimeMessage(string Msg);
        void ShortTimeMessage(string Msg);
    }
}
