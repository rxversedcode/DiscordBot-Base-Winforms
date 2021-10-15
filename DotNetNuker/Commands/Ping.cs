using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace DotNetNuker.Commands
{
    public class Ping : ModuleBase
    {

        [Command("Ping", RunMode = RunMode.Async)]


        public async Task SendPing()
        {
            await ReplyAsync("Hi!");
            
        }

    }
}
