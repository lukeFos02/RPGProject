﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace RPGProject.Classes
{
    public class SaveManagement
    {
        public static void SavePlayer(Player player)
        {
            using (Stream stream = File.Create(SaveFile))
            {
                XmlSerializer ser = new XmlSerializer(player.GetType());
                ser.Serialize(stream, player);
            }
        }

        public static Player LoadPLayer()
        {
            try
            {
                using (Stream stream = File.OpenRead(SaveFile))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Player));
                    return (Player)ser.Deserialize(stream);
                }
            }
            catch
            {
                MessageBox.Show("No Save File Detected");
                return DefaultPlayer;
            }
        }
        private static string SaveFolder
        {
            get
            {
                //get save data for the current user of the pc
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                folder = Path.Combine(folder, "RPG Project");
                folder = Path.Combine(folder, "Player Setting");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                return folder;
            }
        }
        private static string SaveFile
        {
            get
            {
                return Path.Combine(SaveFolder, "Player.xml");
            }
        }

        public static Player DefaultPlayer
        {
            get
            {
                return new Player("Default", 0, 0, 0);
            }   
        }
    }
}
