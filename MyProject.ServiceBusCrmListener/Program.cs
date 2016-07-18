using System;
using Microsoft.ServiceBus.Messaging;
using Microsoft.Xrm.Sdk;

namespace MyProject.ServiceBusCrmListener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SAS ConnectionStringを入力してください");
            var connectionString = Console.ReadLine();
            
            var client = QueueClient.CreateFromConnectionString(connectionString);
            
            client.OnMessage(message =>
                {
                    // PluginのContext情報取得
                    var context = message.GetBody<RemoteExecutionContext>();
                    Console.WriteLine(context.PrimaryEntityId);
                }
                );
            
            Console.WriteLine("処理を終了します。Enterを押下してください。");
            Console.ReadKey();
        }
    }
}
