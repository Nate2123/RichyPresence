using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;

namespace RichyPresence
{
    public partial class RichyPresence : Form
    {
        public RichyPresence()
        {
            InitializeComponent();
        }
        public DiscordRpcClient client;
        bool initialized = false;
        private void button2_Click(object sender, EventArgs e)
        {
            initialized = true;
            client = new DiscordRpcClient($"{textBox5.Text}");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (initialized == false)
            {
                MessageBox.Show("You need to initialize the app first!");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"{textBox2.Text}",
                    State = $"{textBox1.Text}",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = $"{textBox3.Text}",
                        LargeImageText = "Made by RichyPresence",
                        SmallImageKey = $"{textBox4.Text}"
                    }
                });
            }
        }

        
    }
}
