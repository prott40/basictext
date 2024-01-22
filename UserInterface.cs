/* UserInterface.cs
 * Author: Rod Howell
 */
namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// A GUI for a simple text editor.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a Click event on the "Open . . ." menu item.
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void OpenClick(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = uxOpenDialog.FileName;

                try
                {
                    string contents = File.ReadAllText(fileName);
                    uxEditBuffer.Text = contents;

                }
                catch(Exception ex)
                {
                    ErrorMessage(ex);
                }
            }
        }

        /// <summary>
        /// Handles a Click event on the "Save As . . ." menu item.
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void SaveAsClick(object sender, EventArgs e)
        {
            if (uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = uxSaveDialog.FileName;
                string contents = uxEditBuffer.Text;
                try
                {
                    File.WriteAllText(fileName, contents);
                }
                catch(Exception ex)
                {
                    ErrorMessage(ex);
                }
            }
        }
        /// <summary>
        /// takes error from textbox and sends out message box with error 
        /// </summary>
        /// <param name="e"> Execption thrown by textbox</param>
        private static void ErrorMessage(Exception e)
        {
            MessageBox.Show("The following error has occurred: " + e.ToString());
        }
    }
}