﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeWriterWF
{
    public class EditableDocument
    {
        public String Path;
        protected bool NeedChangesSaved = false;
        public List<DockablePanel> OpenEditors = new List<DockablePanel>();

        public bool HasUnsavedChanges { get { return NeedChangesSaved; } }

        public virtual void Load(String Path)
        {
            throw new NotImplementedException();
        }
        
        public virtual void ApplyChanges(String NewText)
        {
            NeedChangesSaved = true;
            // If editors are properly linked through scintilla documents, they should already share changes.
            foreach (var editor in OpenEditors) editor.Text = this.GetEditorTitle();
        }

        public void MadeChanges()
        {
            NeedChangesSaved = true;
            UpdateViewTitles();
        }

        public virtual String GetContents() { throw new NotImplementedException(); }

        public virtual int CountWords(Model Model, Main View) { throw new NotImplementedException(); }
        
        public String GetEditorTitle()
        {
            return (NeedChangesSaved ? "*" : "") + System.IO.Path.GetFileName(Path);
        }

        public virtual void SaveDocument() { }


        public enum CloseStyle
        {
            ForcedWithoutSaving,
            Natural
        }

        public void CloseAllViews(CloseStyle CloseStyle = CloseStyle.Natural)
        {
            var editors = new List<DockablePanel>(OpenEditors);
            foreach (var editor in editors)
            {
                editor.CloseStyle = CloseStyle;
                editor.Close();
            }
        }

        public virtual DockablePanel OpenView(Model Model)
        {
            throw new NotImplementedException();
        }

        public virtual WeifenLuo.WinFormsUI.Docking.DockState GetPreferredOpeningDockState()
        {
            return WeifenLuo.WinFormsUI.Docking.DockState.Document;
        }

        public void UpdateViews()
        {
            foreach (var editor in OpenEditors)
            {
                editor.ReloadDocument();
                editor.Text = GetEditorTitle();
            }
        }

        public void UpdateViewTitles()
        {
            foreach (var editor in OpenEditors)
                editor.Text = GetEditorTitle();
        }
    }
}
