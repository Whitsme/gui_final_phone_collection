// Aaron Whitaker
// Winter 2022
// CIS 207
// GUI Final: Phone Collection

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIFinal
{
    public class PhoneCollection
    {
        List<Phones> thePhones = new List<Phones> { };
        public string jsonPath { get; set; }
        public string imagePath { get; set; }

        // imports the json files and adds them to list
        public void ImportJSON(string jsonDirectory)
        {
            jsonPath = jsonDirectory;
            string[] jsonFiles; 
            // check to see if files are in jsonPath console write error if not
            try { jsonFiles = Directory.GetFiles(jsonDirectory); }
            catch (Exception ex) { Console.WriteLine(ex.Message); return; }
            Phones onePhone = new Phones();
            string jsonData = "";
            foreach (var jsonFile in jsonFiles)
            {
                // Checks to see if JSON files in JSON folder are able to be read, dematerialized, and added to List 'thePhones' // message box warning of file not added and said file name
                try
                {
                    jsonData = File.ReadAllText(jsonFile);
                    onePhone = JsonSerializer.Deserialize<Phones>(jsonData);
                    thePhones.Add(onePhone);
                }
                catch (Exception)
                {
                    MessageBox.Show("'" + Path.GetFileName(jsonFile) + "' file format is invalid and was not added to theMovies List.", "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }
            }
        }
        // gets index of item in thePhones and returns it or add new phone if index not found
        public Phones GetPhone(int index)
        {
            try
            {
                return thePhones[index];
            }
            catch
            {
                return new Phones();
            }
        }
        // returns phone year, brand, and model per index when called
        public string[] GetPhoneCombo()
        {
            string[] phoneStrings = new string[thePhones.Count]; 

            for (int i = 0; i < phoneStrings.Length; i++)
            {
                phoneStrings[i] = "(" + thePhones[i].year + ") " + thePhones[i].brand + thePhones[i].model; 
            }

            return phoneStrings;
        }
        // updates phone in thePhones based on passed id
        public void UpdatePhone(Phones updateMovie)
        {
            int indexToUpdate = GetIndexFromId(updateMovie.id);
            thePhones[indexToUpdate] = updateMovie;
        }
        // saves phone to json file per id passed
        public void SaveAllJSON(string idToSave)
        {
            int indexToSave = GetIndexFromId(idToSave);
            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            try
            {
                string jsonData = JsonSerializer.Serialize(thePhones[indexToSave], jsonOptions);
                string jsonFile = (jsonPath + "/" + thePhones[indexToSave].id + ".json");
                StreamWriter writer = new StreamWriter(jsonFile);
                writer.Write(jsonData);
                writer.Close();
            }
            catch
            {

            }            

        }
        // gets index form id passed and returns the index
        private int GetIndexFromId(string idToFind)
        {
            int foundIndex = -1;

            for (int i = 0; i < thePhones.Count; i++)
            {
                if (thePhones[i].id == idToFind)
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }
    }
}
