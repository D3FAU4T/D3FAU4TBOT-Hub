using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3FAU4TBOT_Hub.Forms
{
    public partial class MyLevelsForm : Form
    {
        private static string MainFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "D3FAU4TBOT Hub");
        private static string LevelFolder = Path.Combine(MainFolder, "My Levels");
        private string DiscordId;

        public MyLevelsForm()
        {
            InitializeComponent();
            DiscordId = GetDiscordId();
            InitializeLevels();
        }

        private async void InitializeLevels()
        {
            var Data = await GetLevelAsync(DiscordId);
            DeserializeArrayAndWrite(Data);
            ExplorerBrowser.Url = new Uri(LevelFolder);
        }

        private string GetDiscordId()
        {
            string ConfigFileText = File.ReadAllText(Path.Combine(MainFolder, "Config.json"));
            Config ConfigFile = JsonConvert.DeserializeObject<Config>(ConfigFileText);
            return ConfigFile.DiscordID;
        }

        private static async Task<LevelStructure[]> GetLevelAsync(string DiscordId)
        {
            using (HttpClient HttpClient = new HttpClient())
            {
                HttpResponseMessage Response = await HttpClient.GetAsync($"https://wos-level-editor.d3fau4tbot.repl.co/d3fau4tbot/getlevels/{DiscordId}");
                if (Response.IsSuccessStatusCode)
                {
                    var Content = await Response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<LevelStructure[]>(Content);
                }

                return null;
            }
        }

        private void DeserializeArrayAndWrite(LevelStructure[] LevelArray)
        {
            foreach (var Level in LevelArray)
            {
                Level.fakeLetters = "";
                Level.hiddenLetters = "";
                Level.reveal = false;
                Level.level = "1";
                Level.lang = Level.Language;
                Level.Language = null;
                Level.timebar = new Timebar
                {
                    timerPercentage = 100,
                    locks = new Locks
                    {
                        total = 5,
                        expired = 0
                    }
                };
                string JSON = JsonConvert.SerializeObject(Level, Formatting.Indented);
                string FilePath = Path.Combine(LevelFolder, $"{Level.Level}.level");
                File.WriteAllText(FilePath, JSON);
            }
        }

        private static string[] GetFileNames(string FolderPath, string FileExtension)
        {
            string[] FileList = Directory.GetFiles(FolderPath, $"*.{FileExtension}");
            string[] FileNames = new string[FileList.Length];

            for (int i = 0; i < FileList.Length; i++)
            {
                FileNames[i] = Path.GetFileName(FileList[i]).Replace(".level", "");
            }

            return FileNames;
        }

        private async void SendArrayToServer()
        {
            string[] Levels = GetFileNames(LevelFolder, "level");
            await PostLevelsData(DiscordId, Levels);
        }

        public async Task PostLevelsData(string DiscordId, string[] Levels)
        {
            using (HttpClient HttpClient = new HttpClient())
            {
                var Content = new StringContent(JsonConvert.SerializeObject(new { DiscordId = DiscordId, Levels = Levels }), Encoding.UTF8, "application/json");
                await HttpClient.PostAsync("https://wos-level-editor.d3fau4tbot.repl.co/d3fau4tbot/synclevel", Content);
                Console.WriteLine("Sent to Database");
            }
        }

        private void SyncWithServerButton_Click(object sender, EventArgs e)
        {
            SendArrayToServer();
        }
    }
}