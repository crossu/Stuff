using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
using FlowOpenAPI;
using System.Web.Services.Discovery;

namespace WCFProxy
{
    public class WCFBuilder
    {
        public async void TestConnection()
        {
            var testCall = new TestCallRequest1("test", "test");

            FlowOpenAPISoapClient client = new FlowOpenAPISoapClient(FlowOpenAPISoapClient.EndpointConfiguration.FlowOpenAPISoap);
            Console.WriteLine(client.TestCallAsync(testCall).Result);
            //TestCallResponse1 respone = await client.TestCallAsync(testCall);

        }
    }
}
