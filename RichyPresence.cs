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
            if (textBox6.Text == "yes")
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
            if (textBox6.Text == "no")
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"{textBox2.Text}",
                    State = $"{textBox1.Text}",
                    Assets = new Assets()
                    {
                        LargeImageKey = $"{textBox3.Text}",
                        LargeImageText = "Made by RichyPresence",
                        SmallImageKey = $"{textBox4.Text}"
                    }
                });
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "State")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "State";

                textBox1.ForeColor = Color.Silver;

            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "App ID")
            {
                textBox5.Text = "";

                textBox5.ForeColor = Color.Black;

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "App ID";

                textBox5.ForeColor = Color.Silver;

            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Large Image Key")
            {
                textBox3.Text = "";

                textBox3.ForeColor = Color.Black;

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Large Image Key";

                textBox3.ForeColor = Color.Silver;

            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Small Image Key")
            {
                textBox4.Text = "";

                textBox4.ForeColor = Color.Black;

            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Small Image Key";

                textBox4.ForeColor = Color.Silver;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Details")
            {
                textBox2.Text = "";

                textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Details";

                textBox2.ForeColor = Color.Silver;

            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Display Time (yes or no)")
            {
                textBox6.Text = "";

                textBox6.ForeColor = Color.Black;

            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Display Time (yes or no)";

                textBox6.ForeColor = Color.Silver;

            }
        }
    }
}
