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
        DiscordSocketClient _client;

        public Form1()
        {
            InitializeComponent();

           
        }


        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            _client = new DiscordSocketClient(new DiscordSocketConfig()
            {
                LogLevel = LogSeverity.Verbose
                
            });

            try
            {
                await _client.LoginAsync(TokenType.Bot, guna2TextBox1.Text);
                await _client.StartAsync();

                guna2HtmlLabel2.Text = "Started!";
            }
            catch
            {
                guna2HtmlLabel2.Text = "Failed.";
            }
            _client.MessageReceived += CommandHandler;
            _client.Log += Log;
           
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private Task CommandHandler(SocketMessage message)
        {
            if (message.Content == "ping")
            {
                
            }
            
            return Task.CompletedTask;
        }

        private Task Log(LogMessage arg)
        {
            Invoke((Action)delegate
            {
                richTextBox1.AppendText(arg.Message + "\n");
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
                this.Size = new Size(706, 408);
                this.CenterToScreen();
            }
            else
            {
                richTextBox1.Hide();
                guna2HtmlLabel4.Hide();
                this.Size = new Size(299, 408);
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
