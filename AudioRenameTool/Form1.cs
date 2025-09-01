using NReco.VideoConverter;
using System;
using System.IO;
using System.Windows.Forms;

namespace AudioRenameTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> renamedFiles = new List<string>(); // Store renamed files

        // Browse for folder
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = dialog.SelectedPath;
                    LoadAudioFiles(dialog.SelectedPath);
                }
            }
        }

        // Load audio files into list
        private void LoadAudioFiles(string folderPath)
        {
            listBoxFiles.Items.Clear();

            string[] audioFiles = Directory.GetFiles(folderPath, "*.*");

            foreach (string file in audioFiles)
            {
                string ext = Path.GetExtension(file).ToLower();
                if (ext == ".mp3" || ext == ".wav" || ext == ".wma" || ext == ".aac" || ext == ".ogg")
                {
                    listBoxFiles.Items.Add(Path.GetFileName(file));
                }
            }
        }

        // Convert OGG to WAV for playback (if needed)
        private string ConvertOggToWav(string oggFile)
        {
            string tempFolder = Path.Combine(Path.GetTempPath(), "AudioRenameTool");
            Directory.CreateDirectory(tempFolder);

            string wavFile = Path.Combine(tempFolder, Path.GetFileNameWithoutExtension(oggFile) + ".wav");

            // Convert if it doesn't exist
            if (!File.Exists(wavFile))
            {
                try
                {
                    var ffmpeg = new NReco.VideoConverter.FFMpegConverter();
                    ffmpeg.ConvertMedia(oggFile, wavFile, "wav");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error converting .ogg to .wav: " + ex.Message);
                    return null;
                }
            }

            return wavFile;
        }

        // When user selects an audio file
        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;

            // Combine folder path + selected file
            string selectedFile = Path.Combine(txtFolder.Text, listBoxFiles.SelectedItem.ToString());

            if (!File.Exists(selectedFile))
            {
                MessageBox.Show("File not found: " + selectedFile);
                return;
            }

            string extension = Path.GetExtension(selectedFile).ToLower();
            string fileToPlay = selectedFile;

            if (extension == ".ogg")
            {
                fileToPlay = ConvertOggToWav(selectedFile);
                if (fileToPlay == null || !File.Exists(fileToPlay))
                {
                    MessageBox.Show("Failed to convert .ogg to .wav");
                    return;
                }
            }

            axWindowsMediaPlayer1.URL = fileToPlay;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        // Copy and rename into "RenamedFiles" folder
        private void btnRename_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem != null && !string.IsNullOrWhiteSpace(textBoxRename.Text))
            {
                string oldFile = Path.Combine(txtFolder.Text, listBoxFiles.SelectedItem.ToString());
                string newFolder = Path.Combine(txtFolder.Text, "RenamedFiles");

                // Make sure the new folder exists
                if (!Directory.Exists(newFolder))
                {
                    Directory.CreateDirectory(newFolder);
                }

                string newFile = Path.Combine(newFolder, textBoxRename.Text + Path.GetExtension(oldFile));

                try
                {
                    if (!File.Exists(newFile))
                    {
                        File.Copy(oldFile, newFile);
                        renamedFiles.Add(newFile);

                        MessageBox.Show($"Copied and renamed to:\n{newFile}", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("A file with that name already exists in the RenamedFiles folder.",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error copying file:\n{ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportLua_Click(object sender, EventArgs e)
        {
            string targetFolder = Path.Combine(txtFolder.Text, "RenamedFiles");
            if (Directory.Exists(targetFolder))
            {
                ExportLuaFile(targetFolder);
            }
            else
            {
                MessageBox.Show("No 'RenamedFiles' folder found. Rename something first.");
            }
        }

        private void ExportLuaFile(string targetFolder)
        {
            if (renamedFiles.Count == 0)
            {
                MessageBox.Show("No renamed files found to export into Lua.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string luaPath = Path.Combine(targetFolder, "Duckpack2.lua");

            using (StreamWriter sw = new StreamWriter(luaPath, false))
            {
                sw.WriteLine("--[[-----------------------------------------------------");
                sw.WriteLine("Prop Hunt - Duckle's Taunt Pack");
                sw.WriteLine("Sounds And Stuff");
                sw.WriteLine("-----------------------------------------------------]]--");
                sw.WriteLine();
                sw.WriteLine("if SERVER then");
                sw.WriteLine();
                sw.WriteLine("\thook.Add( \"ph_AddTaunts\", \"Duckpack2\", function()");
                sw.WriteLine("-- Props taunts ");

                foreach (var file in renamedFiles)
                {
                    string fileName = Path.GetFileName(file);
                    sw.WriteLine("\t\ttable.insert( GAMEMODE.Prop_Taunts, {");
                    sw.WriteLine($"\t\t\t\"taunts/Duckpack2/props/{fileName}\",");
                    sw.WriteLine($"\t\t\t\"{Path.GetFileNameWithoutExtension(fileName)}\"");
                    sw.WriteLine("\t\t} )");
                    sw.WriteLine();
                }

                sw.WriteLine("\tend)");
                sw.WriteLine("end");
            }

            MessageBox.Show($"Lua file created: {luaPath}", "Export Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
