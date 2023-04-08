using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyNotePad
{
    public partial class NotePad_General : Form
    {
        public NotePad_General()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens a file and reads its contents into a textbox.
        /// </summary>
        private void button_open_Click(object sender, EventArgs e)
        {
            if (open_fd.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    textBox_general.Text = File.ReadAllText(open_fd.FileName, Encoding.UTF8);
                    label_operationStatus.Text = "The file was opened successfully";
                }
                catch
                {
                    MessageBox.Show("There was an error while opening", "Error");
                }
            }
            else
            {
                label_operationStatus.Text = "The file opening was canceled";
            }
        }

        /// <summary>
        /// Handles the click event of the save button, allowing the user to save the contents of the textbox to a file.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void button_save_Click(object sender, EventArgs e)
        {
            if (save_fd.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    File.WriteAllText(save_fd.FileName + ".txt", textBox_general.Text, Encoding.UTF8);
                    label_operationStatus.Text = "The file was saved successfully";
                }
                catch
                {
                    MessageBox.Show("There was an error while saving", "Error");
                    label_operationStatus.Text = "There was an error while saving";
                }
            }
            else
            {
                label_operationStatus.Text = "The file saving was canceled";
            }
        }

        /// <summary>
        /// Replaces all occurrences of a given pattern with a given replacement string in the textbox.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void button_replace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_general.Text))
            {
                label_operationStatus.Text = "No matching string found for replacement!";
            }
            else
            {
                textBox_general.Text = textBox_general.Text.Replace(text_pattern.Text, text_replace.Text);
                label_operationStatus.Text = "All replacements were successful";
            }
        }
    }
}
