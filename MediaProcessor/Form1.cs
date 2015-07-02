using MediaProcessor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using Id3;
using Id3.Id3v2;
using NAudio;
using NAudio.Wave;

namespace MediaProcessor
{
    public partial class Form1 : Form
    {
        public string mediaFolder = "";
        public string sourceFilePath;
        public string destinationFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnScanMedia_Click(object sender, EventArgs e)
        {

            lstBox.Items.Clear();

            FolderBrowserDialog fb = new FolderBrowserDialog();
            string selectedFolder = "";
            if (fb.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = fb.SelectedPath;
            }

            mediaFolder = selectedFolder;
            
            var extList = new string[] { ".mp3", ".mp4", ".wmv", ".avi", ".flv", ".mkv", ".mpeg", ".mpg", ".m4v" };

            var files = Directory.GetFiles(selectedFolder).Select(Path.GetFileName)
                .Where(n => extList.Contains(System.IO.Path.GetExtension(n), StringComparer.OrdinalIgnoreCase)).ToList();

            lblSelectedFolder.Text = selectedFolder;

            int count = files.Count();
            for (int i = 0; i <= count - 1; i++)
            {
                lstBox.Items.Add(files[i]);
            }


        }

        //Write this code first not reaslising ID3 v3.1 was obsolete 
        private void btnScanFile_Click(object sender, EventArgs e)
        {
            string selectedFile = lstBox.SelectedItem.ToString();
            string mediaFile = mediaFolder + "\\" + selectedFile;

            using (FileStream fs = System.IO.File.OpenRead(mediaFile))
            {
                if (fs.Length >= 128)
                {
                    MusicID3Tag tag = new MusicID3Tag();
                    fs.Seek(-128, SeekOrigin.End);
                    fs.Read(tag.TAGID, 0, tag.TAGID.Length);
                    fs.Read(tag.Title, 0, tag.Title.Length);
                    fs.Read(tag.Artist, 0, tag.Artist.Length);
                    fs.Read(tag.Album, 0, tag.Album.Length);
                    fs.Read(tag.Year, 0, tag.Year.Length);
                    fs.Read(tag.Comment, 0, tag.Comment.Length);
                    fs.Read(tag.Genre, 0, tag.Genre.Length);
                    string theTAGID = Encoding.Default.GetString(tag.TAGID);

                    if (theTAGID.Equals("TAG"))
                    {
                        string Title = Encoding.Default.GetString(tag.Title);
                        string Artist = Encoding.Default.GetString(tag.Artist);
                        string Album = Encoding.Default.GetString(tag.Album);
                        string Year = Encoding.Default.GetString(tag.Year);
                        string Comment = Encoding.Default.GetString(tag.Comment);
                        string Genre = Encoding.Default.GetString(tag.Genre);

                        lstBoxEpisode.Items.Clear();

                        lstBoxEpisode.Items.Add(Title);
                        lstBoxEpisode.Items.Add(Artist);
                        lstBoxEpisode.Items.Add(Album);
                        lstBoxEpisode.Items.Add(Year);
                        lstBoxEpisode.Items.Add(Comment);
                        lstBoxEpisode.Items.Add(Genre);
                    }
                }
            }
        }

        //Re wrote this code for ID3 v3.24
        private void btnScanLatestVersion_Click(object sender, EventArgs e)
        {
            lstBoxEpisode.Items.Clear();
            string selectedFile = lstBox.SelectedItem.ToString();
            string mediaFile = mediaFolder + "\\" + selectedFile;
                        
                using (var mp3 = new Mp3File(mediaFile))
                {
                    //New instance of fileinfo to retreive filesize
                    FileInfo f = new FileInfo(mediaFile);
                    long fileSize = f.Length;

                    //New instance of TagLib
                    TagLib.File file = TagLib.File.Create(mediaFile);
                    if (file.Tag.IsEmpty)
                    {
                        MessageBox.Show("File does not contain ID3 TAG");
                        return;
                    }
                    
                    Id3Tag tag = mp3.GetTag(Id3TagFamily.FileStartTag);
                    lstBoxEpisode.Items.Add("Title: " + file.Tag.Title);
                    lstBoxEpisode.Items.Add("Description: " + file.Tag.Comment); //Id3.Frames.CommentFramelist instead of CommentFrame
                    lstBoxEpisode.Items.Add("Duration: " + mp3.Audio.Duration);
                    lstBoxEpisode.Items.Add("Publish Date: " + tag.RecordingDate);
                    lstBoxEpisode.Items.Add("File: " + mediaFile);
                    //Deletion date needs adding
                    foreach (ICodec codec in file.Properties.Codecs)
                    {
                        lstBoxEpisode.Items.Add("Encoding: " + codec.Description);
                    }
                    
                    lstBoxEpisode.Items.Add("File Size: " + fileSize);
                    lstBoxEpisode.Items.Add("Bit rate: " + mp3.Audio.Bitrate);
                                        
                }
            //}
        }

        private void btnSelectStub_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Media Files|*.mp3;"; //Add more file types later
            fd.Title = "Select stub media file";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                sourceFilePath = "";
                sourceFilePath = fd.InitialDirectory + fd.FileName;
                lblStub.Text = sourceFilePath;
            }

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Media Files|*.mp3;";
            fd.Title = "Select Original File";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                destinationFilePath = "";
                destinationFilePath = fd.InitialDirectory + fd.FileName;
                lblOriginal.Text = destinationFilePath;
            }
        }

        private void btnMergeStart_Click(object sender, EventArgs e)
        {
            if (sourceFilePath == null)
            {
                MessageBox.Show("Please select source file");
            }
            else if(destinationFilePath == null)
            {
                MessageBox.Show("Please select destination file");
            }
            else
            {
                CombineToEnd(sourceFilePath, destinationFilePath);
            }
        }

        private void btnMergeEnd_Click(object sender, EventArgs e)
        {
            if (sourceFilePath == null)
            {
                MessageBox.Show("Please select source file");
            }
            else if (destinationFilePath == null)
            {
                MessageBox.Show("Please select destination file");
            }
            else
            {
                CombineToStart(sourceFilePath, destinationFilePath);
            }
        }

        public static void CombineToStart(string original, string stub)
        {
            byte[] a = System.IO.File.ReadAllBytes(stub);
            byte[] b = System.IO.File.ReadAllBytes(original);
            byte[] c = new byte[a.Length + b.Length];
            a.CopyTo(c, 0);
            b.CopyTo(c, a.Length);

            string exportFile = "";
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Media Files|*.mp3;";
            fd.Title = "Save File";
            fd.DefaultExt = "*.mp3";
            
            if (fd.ShowDialog() == DialogResult.OK)
            {
                exportFile = fd.InitialDirectory + fd.FileName;
            }

            System.IO.File.WriteAllBytes(exportFile, c);
            
        }

        public static void CombineToEnd(string original, string stub)
        {
            byte[] a = System.IO.File.ReadAllBytes(original);
            byte[] b = System.IO.File.ReadAllBytes(stub);
            byte[] c = new byte[a.Length + b.Length];
            a.CopyTo(c, 0);
            b.CopyTo(c, a.Length);

            string exportFile = "";
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Media Files|*.mp3;";
            fd.Title = "Save File";
            fd.DefaultExt = "*.mp3";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                exportFile = fd.InitialDirectory + fd.FileName;
            }

            System.IO.File.WriteAllBytes(exportFile, c);
        }

        private void btnClearListBox_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }

        private void btnClearEpisodeList_Click(object sender, EventArgs e)
        {
            lstBoxEpisode.Items.Clear();
        }
    }
}