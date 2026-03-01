using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Laba1
{
    public class DocumentTab
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string TextContent { get; set; }
        public bool IsModified { get; set; }
        public int CurrentVersionIndex { get; set; }
        public bool CanRedo { get; private set; }

        public DocumentTab(string fileName = "", string filePath = "")
        {
            FileName = fileName;
            FilePath = filePath;
            TextContent = "";
            IsModified = false;
            CurrentVersionIndex = 0;
            CanRedo = false;
        }
        public void UpdateText(string newText)
        {
            if (newText.Length > TextContent.Length)
            {
                TextContent = newText;
                CurrentVersionIndex = newText.Length;
                CanRedo = false;
                IsModified = true;
            }
            else if (newText != TextContent)
            {
                TextContent = newText;
                CurrentVersionIndex = newText.Length;
                CanRedo = false;
                IsModified = true;
            }
        }
    }
}
