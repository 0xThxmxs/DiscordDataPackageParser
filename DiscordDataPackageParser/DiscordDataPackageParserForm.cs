using Newtonsoft.Json;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace DiscordDataPackageParser
{
    public partial class DiscordDataPackageParserForm : Form
    {
        public string packagePath = string.Empty;

        public DiscordDataPackageParserForm()
        {
            InitializeComponent();
        }

        private void DiscordDataPackageParserForm_Load(object sender, EventArgs e) { }

        /*
        private void InitializeAccountDataGridView(string ID, string Username, int Discriminator) // TODO : Optimize & add other attributes
        {
            dataDataGridView.ColumnCount = 3;
            dataDataGridView.ColumnHeadersVisible = true;

            dataDataGridView.Columns[0].Name = "ID";
            dataDataGridView.Columns[1].Name = "Username";
            dataDataGridView.Columns[2].Name = "Discriminator";

            string[] row1 = new string[] { ID, Username, Discriminator.ToString(),
        "**" };
            object[] rows = new object[] { row1 };

            foreach (string[] rowArray in rows)
            {
                dataDataGridView.Rows.Add(rowArray);
            }
        }
        */

        private void InitializeServerDataGridView(string ID, string Name)
        {
            dataDataGridView.ColumnCount = 2;
            dataDataGridView.ColumnHeadersVisible = true;

            dataDataGridView.Columns[0].Name = "ID";
            dataDataGridView.Columns[1].Name = "Name";

            string[] row1 = new string[] { ID, Name,
        "**" };
            object[] rows = new object[] { row1 };

            foreach (string[] rowArray in rows)
            {
                dataDataGridView.Rows.Add(rowArray);
            }
        }

        private void InitializeMessageDataGridView(string ID, string Type, string Name)
        {
            dataDataGridView.ColumnCount = 3;
            dataDataGridView.ColumnHeadersVisible = true;

            dataDataGridView.Columns[0].Name = "ID";
            dataDataGridView.Columns[1].Name = "Type";
            dataDataGridView.Columns[2].Name = "Name";

            string[] row1 = new string[] { ID, Type, Name,
        "**" };
            object[] rows = new object[] { row1 };

            foreach (string[] rowArray in rows)
            {
                dataDataGridView.Rows.Add(rowArray);
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "~";
                openFileDialog.Filter = "zip files (*.zip)|*.zip";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string zippedPackagePath = openFileDialog.FileName;
                    string[] zippedPackagePathSplited = zippedPackagePath.Split('\\');
                    packagePath = zippedPackagePath.Replace(zippedPackagePathSplited[zippedPackagePathSplited.Length-1], "") + "DiscordDataPackage";

                    if (!Directory.Exists(packagePath))
                    {
                        ZipFile.ExtractToDirectory(zippedPackagePath, packagePath);
                        Application.DoEvents();
                    }

                    // For showing user avatar :
                    /*
                    pictureBox1.Image = new Bitmap(packagePath + "\\account\\avatar.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    */

                    textBox1.Text = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(JsonConvert.DeserializeObject<User>(File.ReadAllText(packagePath + "\\account\\user.json")).Id)) + ".{end}";

                    foreach (string directory in Directory.GetDirectories(packagePath))
                    {
                        string directoryRelative = directory.Replace(packagePath + "\\", "");
                        
                        if (directoryRelative != "activity" && directoryRelative != "programs" && directoryRelative != "account") // For the moment :)
                        {
                            explorerListBox.Items.Add(directory.Replace(packagePath + "\\", ""));
                        }
                    }

                    MessageBox.Show(File.ReadAllText(packagePath + "\\README.txt"), "README.txt", MessageBoxButtons.OK);
                }
            }
        }

        private void ExplorerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataDataGridView.Rows.Clear();
            dataDataGridView.Refresh();

            foreach (string subdirectories in Directory.GetDirectories(packagePath + "\\" + explorerListBox.SelectedItem.ToString()))
            {
                /*
                if (subdirectories.Contains("account"))
                {
                    User user = JsonConvert.DeserializeObject<User>(File.ReadAllText(packagePath + "\\account\\user.json"));
                    InitializeAccountDataGridView(user.Id, user.Username, user.Discriminator);
                    // Application.DoEvents();
                }
                */

                if (subdirectories.Contains("servers")) {
                    Server server = JsonConvert.DeserializeObject<Server>(File.ReadAllText(subdirectories + "\\guild.json"));
                    InitializeServerDataGridView(server.Id, server.Name);
                    // Application.DoEvents();
                }

                if (subdirectories.Contains("messages"))
                {
                    Channel channel = JsonConvert.DeserializeObject<Channel>(File.ReadAllText(subdirectories + "\\channel.json"));
                    foreach (string message in File.ReadAllLines(subdirectories + "\\messages.csv"))
                    {
                        InitializeMessageDataGridView(channel.Id, channel.Name, message);
                        // Application.DoEvents();
                    }
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest sendTokenRequest = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v7/users/@me");
            sendTokenRequest.Method = "GET";
            sendTokenRequest.Headers["authorization"] = textBox1.Text;

            try
            {
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)sendTokenRequest.GetResponse();
                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    string token = textBox1.Text;
                    MessageBox.Show("Connected!\nYou can now use the editor (soon...)", "Success", MessageBoxButtons.OK);
                }
                
                myHttpWebResponse.Close();
            }
            catch
            {
                MessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
