using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace DotNetNuker
{
    public class CommandHandler
    {
        private CommandService Commands { get; set; }
        
        private DiscordSocketClient Client { get; set; }


        public async Task Init(DiscordSocketClient client)
        {
            this.Client = client;
            Commands = new CommandService();

            await Commands.AddModulesAsync(Assembly.GetEntryAssembly(), null);
            Client.MessageReceived += HandleCommand;
        }

        private async Task HandleCommand(SocketMessage Msg)
        {
            var msg = Msg as SocketUserMessage;
            if (msg == null) return;

            int argPos = 0;
            if (!(msg.HasStringPrefix("n!", ref argPos) || msg.HasMentionPrefix(Client.CurrentUser, ref argPos))) return;

            var context = new CommandContext(Client, msg);

            var result = Commands.ExecuteAsync(context, argPos, null);

            if (result.IsFaulted) await context.Channel.SendMessageAsync("Failed to execute command.");
        }
    }
}
