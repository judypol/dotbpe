﻿using System.Threading.Tasks;
using DotBPE.Rpc.Codes;

namespace DotBPE.Rpc
{

    public interface IRpcContext<in TMessage> where TMessage:IMessage
    {
        string RemoteAddress{get;}
        string LocalAddress{get;}

        Task SendAsync(TMessage data);
        Task CloseAsync();
    }
}
