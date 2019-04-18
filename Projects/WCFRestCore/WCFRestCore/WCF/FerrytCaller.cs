using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WCFRestCore.WCF
{
    public static class FerrytCaller
    {
        public static void TestCall()
        {
            WCFProxy.WCFBuilder proxy = new WCFProxy.WCFBuilder();
            proxy.TestConnection();
        }
    }
}
