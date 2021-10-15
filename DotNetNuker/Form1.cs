using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.WebSocket;

namespace DotNetNuker
{
    public partial class Form1 : Form
    {
        public static DiscordSocketClient Client;
        CommandHandler Handler;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();


        }


        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            Handler = new CommandHandler();

            Client = new DiscordSocketClient(new DiscordSocketConfig()
            {
                LogLevel = LogSeverity.Info

            }) ;

           await Handler.Init(Client);

            try
            {
                await Client.LoginAsync(TokenType.Bot, guna2TextBox1.Text);
                await Client.StartAsync();

                await Client.SetGameAsync("with your server.");

                guna2HtmlLabel2.Text = "Started!";
            }
            catch
            {
                guna2HtmlLabel2.Text = "Failed.";
                
            }
            
            Client.Log += Log;
          await  Task.Delay(-1);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        public Task Log(LogMessage arg)
        {
            Invoke((Action)delegate
            {
                richTextBox1.AppendText("\n" + "   " + arg.Message + "\n");
            });
               
            return Task.CompletedTask;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                richTextBox1.Show();
                guna2HtmlLabel4.Show();
                this.Size = new Size(736, 408);
                this.CenterToScreen();
                
            }
            else
            {
                richTextBox1.Hide();
                guna2HtmlLabel4.Hide();
                this.Size = new Size(284, 408);
                this.CenterToScreen();
            }
        }

        private void guna2Separator3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked == true)
            {
                guna2TextBox1.UseSystemPasswordChar = true;
            }
            else
            {
                guna2TextBox1.UseSystemPasswordChar = false;
            }
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel4.Hide();
        }
    }
}
