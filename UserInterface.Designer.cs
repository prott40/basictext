namespace Ksu.Cis300.TextEditor
{
    partial class UserInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uxMenuStrip = new MenuStrip();
            uxFile = new ToolStripMenuItem();
            uxOpen = new ToolStripMenuItem();
            uxSaveAs = new ToolStripMenuItem();
            uxTextBox = new TextBox();
            uxOpenFileDialog = new OpenFileDialog();
            uxSaveFileDialog = new SaveFileDialog();
            uxMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // uxMenuStrip
            // 
            uxMenuStrip.Items.AddRange(new ToolStripItem[] { uxFile });
            uxMenuStrip.Location = new Point(0, 0);
            uxMenuStrip.Name = "uxMenuStrip";
            uxMenuStrip.Size = new Size(743, 24);
            uxMenuStrip.TabIndex = 0;
            uxMenuStrip.Text = "menuStrip1";
            // 
            // uxFile
            // 
            uxFile.DropDownItems.AddRange(new ToolStripItem[] { uxOpen, uxSaveAs });
            uxFile.Name = "uxFile";
            uxFile.Size = new Size(37, 20);
            uxFile.Text = "File";
            uxFile.Click += File_Click;
            // 
            // uxOpen
            // 
            uxOpen.Name = "uxOpen";
            uxOpen.Size = new Size(112, 22);
            uxOpen.Text = "Open";
            uxOpen.Click += Open_Click;
            // 
            // uxSaveAs
            // 
            uxSaveAs.Name = "uxSaveAs";
            uxSaveAs.Size = new Size(112, 22);
            uxSaveAs.Text = "Save as";
            uxSaveAs.Click += SaveAs_Click;
            // 
            // uxTextBox
            // 
            uxTextBox.Location = new Point(12, 27);
            uxTextBox.Multiline = true;
            uxTextBox.Name = "uxTextBox";
            uxTextBox.Size = new Size(719, 524);
            uxTextBox.TabIndex = 1;
            // 
            // uxSaveFileDialog
            // 
            uxSaveFileDialog.FileOk += SaveFileDialogFileOk;
            // 
            // uxUserInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 563);
            Controls.Add(uxTextBox);
            Controls.Add(uxMenuStrip);
            MainMenuStrip = uxMenuStrip;
            Name = "uxUserInterface";
            Text = "Text Editor";
            uxMenuStrip.ResumeLayout(false);
            uxMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip uxMenuStrip;
        private ToolStripMenuItem uxFile;
        private ToolStripMenuItem uxOpen;
        private ToolStripMenuItem uxSaveAs;
        private TextBox uxTextBox;
        private OpenFileDialog uxOpenFileDialog;
        private SaveFileDialog uxSaveFileDialog;
    }
}