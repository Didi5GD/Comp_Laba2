using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Laba1
{
    public class RichTextBoxEditOperations
    {
        private RichTextBox richTextBox;

        public RichTextBoxEditOperations(RichTextBox rtb)
        {
            richTextBox = rtb;
            richTextBox.KeyDown += RichTextBox_KeyDown;
        }

        private void RichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.C:
                        Copy();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.V:
                        Paste();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.X:
                        Cut();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Z:
                        Undo();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Y:
                        Redo();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.A:
                        SelectAll();
                        e.SuppressKeyPress = true;
                        break;
                }
            }
        }

        public void Undo()
        {
            if (richTextBox.CanUndo)
            {
                richTextBox.Undo();
            }
        }

        public void Redo()
        {
            if (richTextBox.CanRedo)
            {
                richTextBox.Redo();
            }
        }

        public void Cut()
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Cut();
            }
        }
        public void Copy()
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Copy();
            }
        }

        public void Paste()
        {
            if (Clipboard.ContainsText())
            {
                richTextBox.Paste();
            }
        }

        public void Delete()
        {
            if (richTextBox.SelectionLength > 0)
            {
                int start = richTextBox.SelectionStart;
                int length = richTextBox.SelectionLength;
                richTextBox.Text = richTextBox.Text.Remove(start, length);
                richTextBox.SelectionStart = start;
            }
        }
        public void SelectAll()
        {
            richTextBox.SelectAll();
        }
    }
}
