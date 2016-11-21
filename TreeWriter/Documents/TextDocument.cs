﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeWriterWF
{
    public class TextDocument : EditableDocument
    {
        public String Contents;

        public TextDocument(String FileName)
        {
            Path = FileName;
            Contents = System.IO.File.ReadAllText(FileName);
        }

        public override string GetContents()
        {
            return Contents;
        }

        public override int CountWords()
        {
            return WordParser.CountWords(Contents);
        }

        public override void ApplyChanges(string NewText)
        {
 	        Contents = NewText;
            base.ApplyChanges(NewText);
        }

        public override void SaveDocument()
        {

            System.IO.File.WriteAllText(Path, Contents);
            NeedChangesSaved = false;
            UpdateViewTitles();
        }

        public override OpenDocumentRecord GetOpenDocumentRecord()
        {
            return new OpenDocumentRecord
            {
                Path = Path,
                Type = "TEXT"
            };
        }

        public override DockablePanel OpenView(Model Model)
        {
            var r = new TextDocumentEditor(this, 
                OpenEditors.Count != 0 ? (OpenEditors[0] as TextDocumentEditor).GetScintillaDocument() : (ScintillaNET.Document?)null,
                Model.SpellChecker, Model.Thesaurus);
            OpenEditors.Add(r);
            return r;
        }

    }
}
