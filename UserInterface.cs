/* UserInterface.cs
 * Author: Rod Howell
 */
using System.Runtime.CompilerServices;
using System.Text;
namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// A GUI for a simple text editor.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The number of characters to rotate when encrypting.
        /// </summary>
        private const int _rotationDistance = 13;

        /// <summary>
        /// The number of characters in the alphabet.
        /// </summary>
        private const int _alphabetLength = 26;

        /// <summary>
        /// The first letter of the lower-case alphabet.
        /// </summary>
        private const char _lowerCaseStart = 'a';

        /// <summary>
        /// The first letter of the upper-case alphabet.
        /// </summary>
        private const char _upperCaseStart = 'A';
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
                try
                {
                    uxEditBuffer.Text = File.ReadAllText(uxOpenDialog.FileName);
                }
                catch (Exception ex)
                {
                    ShowError(ex);
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
                try
                {
                    File.WriteAllText(uxSaveDialog.FileName, uxEditBuffer.Text);
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        /// <summary>
        /// Displays the given exception to the user.
        /// </summary>
        /// <param name="e">The exception to show.</param>
        private static void ShowError(Exception e)
        {
            MessageBox.Show("The following error occurred: " + e);
        }
        /// <summary>
        /// Rotates the given character c through the alphabet whose first
        /// letter is firstLetter.
        /// </summary>
        /// <param name="c">The character to rotate.</param>
        /// <param name="firstLetter">The first letter of the alphabet.</param>
        /// <returns>The result of the rotation.</returns>
        private static char Rotate(char c, char firstLetter)
        {
            return (char)(firstLetter + (c - firstLetter + _rotationDistance) % _alphabetLength);
        }
        /// <summary>
        /// checks the length of the alphabet
        /// </summary>
        /// <param name="check">char being checked</param>
        /// <param name="alpha">leter that starts the alphabet</param>
        /// <returns>true if inside alphabet flase if not</returns>
        private static bool CaseFinder(char check, char alpha)
        {
            if (check >= alpha && check < (alpha + _alphabetLength))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// encrypts a single character
        /// </summary>
        /// <param name="en">letter being incrypted</param>
        /// <returns> enctypted char </returns>
        private static char Encrypt(char en)
        {
            char encrypted = 'e';
            if (CaseFinder(en, _lowerCaseStart))
            {
                encrypted = Rotate(en, _lowerCaseStart);
            }
            else if (CaseFinder(en, _upperCaseStart))
            {
                encrypted = Rotate(en, _upperCaseStart);
            }
            else
            {
                encrypted = en;
            }
            return encrypted;
        }
        /// <summary>
        /// enryptes texbox using string
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void WithString(object sender, EventArgs e)
        {
            string contents = uxEditBuffer.Text;
            string result = "";
            for (int i = 0; i < contents.Length; i++)
            {
                result += Encrypt(contents[i]);
            }
            uxEditBuffer.Text = result;
        }
        /// <summary>
        /// ebcrypts using a string builder
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event</param>
        private void WithStringBuilder(object sender, EventArgs e)
        {
            StringBuilder sb = new();
            string contents = uxEditBuffer.Text;
            for(int i = 0; i < contents.Length; i++)
            {
                sb.Append(Encrypt(contents[i]));
            }
            uxEditBuffer.Text = sb.ToString();
        }
    }
}
// get contnets of textbok before gathering everything from it