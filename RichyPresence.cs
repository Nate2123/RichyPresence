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
            if (initialized == true)
            {
                MessageBox.Show("Initializing twice will break the program.");
            }
            else
            {
                initialized = true;
                client = new DiscordRpcClient($"{textBox5.Text}");
                client.Initialize();
            }
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
                    Buttons = new DiscordRPC.Button[]
                    {
                    new DiscordRPC.Button() { Label = $"{textBox6.Text}", Url = $"{textBox7.Text}" }
                    },
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

        

        private void button3_Click(object sender, EventArgs e)
        {
            if (initialized == false)
            {
                MessageBox.Show("Why would you want to turn off a program that's already off");
                
            }
            
            else
            {
                initialized = false;
                client.Dispose();
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Button Text")
            {
                textBox6.Text = "";

                textBox6.ForeColor = Color.Black;

            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Button Text";

                textBox6.ForeColor = Color.Silver;

            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Button URL")
            {
                textBox7.Text = "";

                textBox7.ForeColor = Color.Black;

            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Button URL";

                textBox7.ForeColor = Color.Silver;

            }
        }
    }
}
