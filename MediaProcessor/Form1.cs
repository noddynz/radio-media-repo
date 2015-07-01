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

namespace MediaProcessor
{
    public partial class Form1 : Form
    {
        public string mediaFolder = "E:\\Media";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnScanMedia_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            var extList = new string[] { ".mp3" };

            var files = Directory.GetFiles(mediaFolder).Select(Path.GetFileName)
                .Where(n => extList.Contains(System.IO.Path.GetExtension(n), StringComparer.OrdinalIgnoreCase)).ToList();

            lblSelectedFolder.Text = mediaFolder;

            int count = files.Count();
            for (int i = 0; i <= count - 1; i++)
            {
                lstBox.Items.Add(files[i]);
            }


        }

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

        private void btnScanLatestVersion_Click(object sender, EventArgs e)
        {
            lstBoxEpisode.Items.Clear();
            string selectedFile = lstBox.SelectedItem.ToString();
            string mediaFile = mediaFolder + "\\" + selectedFile;

            //if (mediaFile.Contains("*.mp3"))
            //{

                using (var mp3 = new Mp3File(mediaFile))
                {
                    FileInfo f = new FileInfo(mediaFile);
                    long fileSize = f.Length;

                    Id3Tag tag = mp3.GetTag(Id3TagFamily.FileStartTag);
                    lstBoxEpisode.Items.Add("Title: " + tag.Title.Value);
                    lstBoxEpisode.Items.Add("Description: " + tag.Comments);
                    //Duration needs adding
                    lstBoxEpisode.Items.Add("Publish Date: " + tag.RecordingDate);
                    lstBoxEpisode.Items.Add("File: " + mediaFile);
                    //Deletion date needs adding
                    lstBoxEpisode.Items.Add("Encoding: " + tag.Encoder);
                    lstBoxEpisode.Items.Add("File Size: " + fileSize);
                    //Bit rate needs adding. ((((fileSize)/ duration)/1024)*8)
                    lstBoxEpisode.Items.Add("Format: MP3");


                }
            //}
        }
    }
}
