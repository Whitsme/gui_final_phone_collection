// Aaron Whitaker
// Winter 2022
// CIS 207
// GUI Final: Phone Collection

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIFinal
{   
    // sets class 
    public partial class Form1 : Form
    {
        // stores all the data and methods for this form's logic
        PhoneCollection thePhones = new PhoneCollection();
        
        // initialized the form
        public Form1()
        {
            InitializeComponent();
        }
        // method is for event from user click 'buttonJSON_Click' // opens computer folder browser for folder selection // sets 'thePhones.ImportJSON' to user selected folder 
        private void buttonJSON_Click_1(object sender, EventArgs e)
        {
            // opens computer folder browser for folder selection 
            folderBrowserDialogJSON.ShowDialog();
            
            // sets 'jsonPath' to user selected folder
            thePhones.ImportJSON(folderBrowserDialogJSON.SelectedPath);
            // adds 'jsonPath' to list for checking if files are in selected folder in below if statement
            string[] testFiles = Directory.GetFiles(thePhones.jsonPath);
            if (testFiles.Length == 0)
            {
                MessageBox.Show("No files in selected folder.", "No JSON files", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // method is for event from user click 'buttonImages_Click_1' // opens computer folder browser for folder selection // sets 'thePhones.imagePath' to user selected folder 
        private void buttonImages_Click_1(object sender, EventArgs e)
        {
            // opens computer folder browser for folder selection 
            folderBrowserDialogImages.ShowDialog();
            // sets 'imagePath' to user selected folder
            thePhones.imagePath = folderBrowserDialogImages.SelectedPath;

            // adds 'imagePath' to list for checking if files are in selected folder in below if statement
            string[] testFiles = Directory.GetFiles(thePhones.imagePath);
            if (testFiles.Length == 0)
            {
                MessageBox.Show("No files in selected folder.", "No image files", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonOpenEditor_Click_1(object sender, EventArgs e)
        {
            // adds 'jsonPath" and 'imagePath' to lists for checking if files are in selected folder in below if statement
            string[] testJson = Directory.GetFiles(thePhones.jsonPath);
            string[] testImage = Directory.GetFiles(thePhones.imagePath);
            // only opens MovieEditor form is both jsonPath and imagePath contain files
            if (testJson.Length != 0 && testImage.Length != 0)
            {
                PhoneEditor openEditor = new PhoneEditor(thePhones);
                // opens class form window 'MovieEditor'
                openEditor.Show();
            }
            else
            {
                MessageBox.Show("Please select valid folders containing files for both the JSON movies and their images.", "No files", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
