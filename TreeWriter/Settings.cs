﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TreeWriterWF
{
    public class Settings
    {
        [Newtonsoft.Json.JsonIgnore]
        public Action OnEditorFontChanged;

        public String Dictionary { get; set; }
        public String Thesaurus { get; set; }
        public List<String> CustomDictionaryEntries { get; set; }

        private System.Drawing.Font _editorFont = null;
        
        public System.Drawing.Font EditorFont 
        {
            get
            {
                return _editorFont;
            }
            set
            {
                _editorFont = value;
                if (OnEditorFontChanged != null) OnEditorFontChanged();
            }
        }

        public Settings()
        {
            Dictionary = "en_US";
            Thesaurus = "th_en_US_new.dat";
            CustomDictionaryEntries = new List<string>();
            EditorFont = new System.Drawing.Font("Arial", 12);
        }        
    }
}