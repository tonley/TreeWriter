﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TreeWriterWF.Commands.Extract
{
    public class ExtractManuscript : ICommand
    {
        private String Path;
        private ExtractionSettings Settings;
        public bool Succeeded { get; private set; }

        public ExtractManuscript(String Path, ExtractionSettings Settings)
        {
            this.Path = Path;
            this.Settings = Settings;
            Succeeded = false;
        }

        public void Execute(Model Model, Main View)
        {
            if (System.IO.File.Exists(Settings.DestinationFile))
                if (System.Windows.Forms.MessageBox.Show(
                    String.Format("{0} already exists. Overwrite?", Settings.DestinationFile), 
                    "Warning", System.Windows.Forms.MessageBoxButtons.YesNo) 
                    != System.Windows.Forms.DialogResult.Yes)
                    return;

            ManuscriptFormatter formatter = null;
            switch (Settings.Format)
            {
                case ExtractionSettings.Formats.PlainText:
                    formatter = new PlainTextFormatter();
                    break;
                case ExtractionSettings.Formats.Latex:
                    formatter = new LatexFormatter();
                    break;
            }

            var chapter = 0;
            var scenesInChapter = 0;

            /* Iterate over files instead!
            foreach (var scene in Document.Scenes)
            {
                if (scene.SkipOnExtract) continue;

                if (scene.StartsNewChapter)
                {
                    chapter += 1;
                    if (String.IsNullOrEmpty(scene.ChapterName))
                        formatter.BeginChapter(String.Format("Chapter {0}", chapter));
                    else
                        formatter.BeginChapter(scene.ChapterName);
                    scenesInChapter = 0;
                }

                if (scenesInChapter > 0)
                    formatter.AddSceneBreak(Document.ExtractionSettings.SceneSeperator);

                formatter.AddScene(scene.Prose);

                scenesInChapter += 1;

                if (scene.StopExtractionHere)
                    break;
            }

            System.IO.File.WriteAllText(Document.ExtractionSettings.DestinationFile, formatter.ToString());
            Succeeded = true;
            */
        }
    }
}
