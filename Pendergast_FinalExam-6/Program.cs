using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_FinalExam_6
{
    public class PlayerSettings
    {
        private static PlayerSettings instance;
        private static readonly object padlock = new object();

        public string PlayerName {get; set;}
        public int Level {get; set;}
        public int Hp {get; set;}
        public string[] Inventory {get; set;}
        public string LicenseKey {get; set;}

        private PlayerSettings()
        {
            PlayerName = "";
            Level = 0;
            Hp = 0;
            Inventory = new string[0];
            LicenseKey = "";
        }

        public static PlayerSettings Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PlayerSettings();
                    }
                    return instance;
                }
            }
        }

        public void Load(string filePath)
        {
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                PlayerSettings settings = (PlayerSettings)serializer.Deserialize(file, typeof(PlayerSettings));
                PlayerName = settings.PlayerName;
                Level = settings.Level;
                Hp = settings.Hp;
                Inventory = settings.Inventory;
                LicenseKey = settings.LicenseKey;
            }
        }

        public void Save(string filePath)
        {
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, this);
            }
        }
    }
}
