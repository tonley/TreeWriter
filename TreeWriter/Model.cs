﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TreeWriterWF
{
    public class Model
    {
        private List<EditableDocument> OpenDocuments = new List<EditableDocument>();

        public NHunspell.Hunspell SpellChecker { get; private set; }
        public NHunspell.MyThes Thesaurus;
        public Settings Settings;

        public class SerializableSettings
        {
            public List<String> OpenDocuments;
            public Settings Settings;
        }

        public void LoadSettings(Main View)
        {
            try
            {
                var settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BleckiTreeWriter\\settings.txt";
                SerializableSettings settingsObject = null;

                if (System.IO.File.Exists(settingsPath))
                {
                    var text = System.IO.File.ReadAllText(settingsPath);
                    settingsObject = JsonConvert.DeserializeObject<SerializableSettings>(text);
                    if (settingsObject != null) this.Settings = settingsObject.Settings;
                }

                if (this.Settings == null) this.Settings = new Settings();

                SpellChecker = new NHunspell.Hunspell(Settings.Dictionary + ".aff", Settings.Dictionary + ".dic");
                Thesaurus = new NHunspell.MyThes(Settings.Thesaurus);

                if (settingsObject != null)
                    foreach (var document in settingsObject.OpenDocuments)
                        View.ProcessControllerCommand(new Commands.OpenPath(document,
                            Commands.OpenCommand.OpenStyles.CreateView));

                foreach (var word in Settings.CustomDictionaryEntries)
                    SpellChecker.Add(word);

            }
            catch (Exception e)
            {
                SpellChecker = new NHunspell.Hunspell("en_US.aff", "en_US.dic");
                Thesaurus = new NHunspell.MyThes("th_en_US_new.dat");

                System.Windows.Forms.MessageBox.Show("Error loading settings.", "Alert!", System.Windows.Forms.MessageBoxButtons.OK);
            }
        }

        public void SaveSettings()
        {
            try
            {
                var settingsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BleckiTreeWriter";
                if (!System.IO.Directory.Exists(settingsDirectory))
                    System.IO.Directory.CreateDirectory(settingsDirectory);
                var settingsPath = settingsDirectory + "\\settings.txt";

                var settingsObject = new SerializableSettings
                {
                    OpenDocuments = OpenDocuments.Select(d => d.Path).ToList(),
                    Settings = Settings
                };
                
                System.IO.File.WriteAllText(settingsPath, JsonConvert.SerializeObject(settingsObject, Formatting.Indented));
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error saving settings.", "Alert!", System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        public EditableDocument FindOpenDocument(String FileName)
        {
            return OpenDocuments.FirstOrDefault(d => d.Path.ToUpper() == FileName.ToUpper());
        }

        public IEnumerable<EditableDocument> FindChildDocuments(String BaseFileName)
        {
            foreach (var document in OpenDocuments)
                if (document.Path.ToUpper().StartsWith(BaseFileName.ToUpper())) yield return document;
        }

        /// <summary>
        /// Close an open document.
        /// DocumentEditors will be orphaned. 
        /// </summary>
        /// <param name="Document"></param>
        public void CloseDocument(EditableDocument Document)
        {
            System.Diagnostics.Debug.Assert(Document.OpenEditors.Count <= 1);
            OpenDocuments.Remove(Document);
        }

        public void OpenDocument(EditableDocument Document)
        {
            OpenDocuments.Add(Document);
        }

        public IEnumerable<EditableDocument> EnumerateOpenDocuments()
        {
            return OpenDocuments;
        }
    }
}
