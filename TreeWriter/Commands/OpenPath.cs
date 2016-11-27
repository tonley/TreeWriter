﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeWriterWF.Commands
{
    public class OpenPath : ICommand
    {
        private String FileName;
        private OpenCommand.OpenStyles OpenStyle = OpenCommand.OpenStyles.CreateView;
        internal EditableDocument Document;
        public bool Succeeded { get; private set; }

        public OpenPath(String FileName, OpenCommand.OpenStyles OpenStyle)
        {
            this.FileName = FileName;
            this.OpenStyle = OpenStyle;
            Succeeded = false;
        }

        public void Execute(Model Model, Main View)
        {
            var extension = System.IO.Path.GetExtension(FileName);
            OpenCommand realCommand = null;

            if (extension == ".txt")
                realCommand = new OpenCommand<TextDocument>(FileName, OpenStyle);
            else if (extension == ".ms")
                realCommand = new OpenCommand<ManuscriptDocument>(FileName, OpenStyle);
            else if (System.IO.Directory.Exists(FileName))
                realCommand = new OpenCommand<FolderDocument>(FileName, OpenStyle);
            else
                throw new InvalidOperationException("Unknown file type");

            realCommand.Execute(Model, View);
            Succeeded = realCommand.Succeeded;
            Document = realCommand.Document;
        }
    }
}