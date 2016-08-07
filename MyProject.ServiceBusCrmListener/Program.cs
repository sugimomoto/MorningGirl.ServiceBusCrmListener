using System;
using Microsoft.ServiceBus.Messaging;
using Microsoft.Xrm.Sdk;
using System.Threading;

namespace MorningGirl.ServiceBusCrmListener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SAS ConnectionStringを入力してください");
            var connectionString = Console.ReadLine();
            
            // 1秒ごとにメッセージを取得
            while(true){

                var counter = 0;

                var client = QueueClient.CreateFromConnectionString(connectionString);

                client.OnMessage(message =>
                    {
                        // PluginのContext情報取得
                        var context = message.GetBody<RemoteExecutionContext>();
                        var input = context.InputParameters["Target"] as Entity;
                        Console.WriteLine(string.Format("count : {0} , EntityId : {1} , EntityName : {2}, RecordName : {3}",counter,context.PrimaryEntityId,context.PrimaryEntityName,input["name"].ToString()));

                        counter++;
                    }
                    );
                   
                Thread.Sleep(1000);
            }
        }
    }
}
