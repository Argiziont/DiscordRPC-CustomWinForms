using System;
using System.IO;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC_CustomWinForms.Extensions;

namespace DiscordRPC_CustomWinForms
{
    public partial class Form1 : Form
    {
        private readonly RpCapi _rpc;
        public Form1()
        {
            InitializeComponent();
            _rpc= new RpCapi();
            WriteToFields();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            if (DiscordRpcClientTextBox.Text.Length == 0)
            {
                MessageBox.Show(@"You couldn't start rpc without client id");
                return;
            }

            _rpc.Initialize(DiscordRpcClientTextBox.Text);
            ReadFields();
            timer1.Interval = 150;
            timer1.Start();
            StopButton.Enabled = true;
            SetButton.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _rpc.Client.Invoke();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            _rpc.Client.Dispose();
            StopButton.Enabled = false;
            SetButton.Enabled = false;
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            ReadFields();
        }

        private void ReadFields()
        {
            var details = DetailsTextBox.Text;
            var state = StateTextBox.Text;
            var largeImageKey = LargeImageKeyTextBox.Text;
            var largeImageText = LargeImageTextTextBox.Text;
            var smallImageKey = SmallImageKeyTextBox.Text;
            var timestamps = TimeStampsTextBox.Text.Length > 0 ? Convert.ToInt32(TimeStampsTextBox.Text) : 0;
            var smallImageText = SmallImageTextTextBox.Text;
            var party = MaxPartyTextBox.Text.Length > 0 ? Convert.ToInt32(MaxPartyTextBox.Text) : 0;
            var size = SizePartyTextBox.Text.Length > 0 ? Convert.ToInt32(SizePartyTextBox.Text) : 0;
            if (size > 0 && party > 0)
            {
                _rpc.Client.SetPresence(new RichPresence
                {
                    Details = details,
                    State = state,
                    Assets = new Assets()
                    {
                        LargeImageKey = largeImageKey,
                        LargeImageText = largeImageText,
                        SmallImageKey = smallImageKey,
                        SmallImageText = smallImageText
                    },
                    Party = new Party { ID = "Secret", Max = party, Size = size }
                });
                if (timestamps > 0)
                {
                    _rpc.Client.SetPresence(new RichPresence
                    {
                        Details = details,
                        State = state,
                        Assets = new Assets()
                        {
                            LargeImageKey = largeImageKey,
                            LargeImageText = largeImageText,
                            SmallImageKey = smallImageKey,
                            SmallImageText = smallImageText
                        },
                        Timestamps = Timestamps.FromTimeSpan(timestamps),
                        Party = new Party { ID = "Secret", Max = party, Size = size }
                    });
                }
            }
            else if (timestamps > 0)
            {
                _rpc.Client.SetPresence(new RichPresence
                {
                    Details = details,
                    State = state,
                    Assets = new Assets()
                    {
                        LargeImageKey = largeImageKey,
                        LargeImageText = largeImageText,
                        SmallImageKey = smallImageKey,
                        SmallImageText = smallImageText
                    },
                    Timestamps = Timestamps.FromTimeSpan(timestamps),
                });
            }
            else
            {
                _rpc.Client.SetPresence(new RichPresence
                {
                    Details = details,
                    State = state,
                    Assets = new Assets()
                    {
                        LargeImageKey = largeImageKey,
                        LargeImageText = largeImageText,
                        SmallImageKey = smallImageKey,
                        SmallImageText = smallImageText
                    },
                });
            }

            using var writer = new BinaryWriter(File.Open("Settings.ini", FileMode.Create));

                writer.Write(details);
                writer.Write(state);
                writer.Write(largeImageKey);
                writer.Write(largeImageText);
                writer.Write(smallImageKey);
                writer.Write(timestamps);
                writer.Write(smallImageText);
                writer.Write(party);
                writer.Write(size);
                writer.Write(DiscordRpcClientTextBox.Text);

        }

        private void WriteToFields()
        {
            if (!File.Exists("Settings.ini")) return;
            using var reader = new BinaryReader(File.Open("Settings.ini", FileMode.Open));
            while (reader.PeekChar() > -1)
            {
                try
                {
                    DetailsTextBox.Text = reader.ReadString();
                    StateTextBox.Text = reader.ReadString();
                    LargeImageKeyTextBox.Text = reader.ReadString();
                    LargeImageTextTextBox.Text = reader.ReadString();
                    SmallImageKeyTextBox.Text = reader.ReadString();
                    TimeStampsTextBox.Text = reader.ReadInt32().ToString();
                    SmallImageTextTextBox.Text = reader.ReadString();
                    MaxPartyTextBox.Text = reader.ReadInt32().ToString();
                    SizePartyTextBox.Text = reader.ReadInt32().ToString();
                    DiscordRpcClientTextBox.Text= reader.ReadString();
                }
                catch
                {

                    reader.Close();
                    File.Delete("Settings.ini");
                }
              
            }
        }
    }
}
