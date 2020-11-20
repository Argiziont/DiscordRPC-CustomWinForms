using System;
using DiscordRPC;
using DiscordRPC.Logging;

namespace DiscordRPC_CustomWinForms.Extensions
{
    public  class RpCapi
    {
        public DiscordRpcClient Client { get; set; }

        public void Initialize(string clientId)
        {
            /*
            Create a Discord client
            NOTE: 	If you are using Unity3D, you must use the full constructor and define
                     the pipe connection.
            */
           Client = new DiscordRpcClient(clientId) {Logger = new ConsoleLogger() {Level = LogLevel.Warning}};

            //Set the logger

            //Subscribe to events
            Client.OnReady += (_, e) =>
            {
                Console.WriteLine(@"Received Ready from user {0}", e.User.Username);
            };

            Client.OnPresenceUpdate += (_, e) =>
            {
                Console.WriteLine(@"Received Update! {0}", e.Presence);
            };

            //Connect to the RPC
            Client.Initialize();
        }
	}
}
