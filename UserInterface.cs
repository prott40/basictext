namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// User interface class
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// initalizes user interface
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// mistake
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Information about the event<param>
        private void SaveFileDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        /// <summary>
        /// mistake
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void File_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// opens a file
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void Open_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fileName = uxOpenFileDialog.FileName;
                MessageBox.Show(fileName + " Can not be opened");
            }

        }
        /// <summary>
        /// saves a file
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void SaveAs_Click(object sender, EventArgs e)
        {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fileName = uxSaveFileDialog.FileName;
                MessageBox.Show(fileName + " Can not be saved");
            }
        }

        
    }
}
