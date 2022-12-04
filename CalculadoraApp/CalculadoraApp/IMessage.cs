using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraApp
{
    public interface IMessage
    {
        void MsgCurta(string mensagem);
        void MsgLonga(string mensagem);
    }
}
