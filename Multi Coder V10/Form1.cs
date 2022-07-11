using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaInfoLib;
using siof = System.IO.File;
using Ini;

namespace Multi_Coder_V10
{
    public partial class Form1 : Form
    {
        CodecList ReadCodectList = new CodecList();
        string destination;
        string FromBoxes;
        string ffCode;
        string logpath;
        string logfilename;
        string extension;
        bool addAduio;
        string fromlistview;
        CodecState state;
        IniFile ini = new IniFile(Environment.CurrentDirectory + "\\Config.ini");
        public Form1()
        {
            InitializeComponent();
            FillLastClosing();
           
        }

        private void FillLastClosing()
        {
            ReadCodectList.ReadCodec();
            destination = ReadCodectList.Destination;
            TxtTarget.Text = destination;
            BoxCodec.SelectedIndex = ReadCodectList.BoxCodec;
            BoxBit.SelectedIndex = ReadCodectList.BoxBit;
            BoxRes.SelectedIndex = ReadCodectList.BoxRes;
           
            BoxField.SelectedIndex = ReadCodectList.BoxField;
            BoxSpeed.SelectedIndex = ReadCodectList.BoxSpeed;
            BoxFrame.SelectedIndex = ReadCodectList.BoxFrame;
        }
        //listview Que Drag Drop 
        private void listViewQue_DragDrop(object sender, DragEventArgs e)
        {
            int i;
            i = 0;
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                if (System.IO.Path.GetExtension(file).Equals(".mxf", StringComparison.InvariantCultureIgnoreCase) || (System.IO.Path.GetExtension(file).Equals(".ogg", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".swf", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".webm", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".avi", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".m2v", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".m4v", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".m2v", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".ts", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".mts", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".mp4", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".mpeg", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".mov", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".vob", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".flv", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".mpg", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".mkv", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".wmv", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".mp3", StringComparison.InvariantCultureIgnoreCase)) || (System.IO.Path.GetExtension(file).Equals(".wav", StringComparison.InvariantCultureIgnoreCase)))
                {
                    string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                    string[] sizes = { "B", "KB", "MB", "GB" };
                    double len = new FileInfo(Path.GetFullPath(s[i])).Length;
                    int order = 0;
                    while (len >= 1024 && order + 1 < sizes.Length)
                    {
                        order++;
                        len = len / 1024;
                    }
                    string result = String.Format("{0:0.##} {1}", len, sizes[order]);
                    string fileName = Path.GetFullPath(s[i]);
                    string fileExt = Path.GetExtension(s[i]);
                    MediaInfo MediaInfoLib = new MediaInfo();
                    MediaInfoLib.Open(Path.GetFullPath(s[i]));
                    string durationinfo = MediaInfoLib.Get(StreamKind.General, 0, "Duration/String3");
                    string audiostreams = MediaInfoLib.Count_Get(StreamKind.Audio).ToString();
                    string audiochannel = MediaInfoLib.Get(StreamKind.Audio, 0, "Channel(s)");
                    string audioID = MediaInfoLib.Get(StreamKind.Audio, 0, "ID");
                    string videoID = MediaInfoLib.Get(StreamKind.Video, 0, "ID");
                    string MinfoContainerFormat = MediaInfoLib.Get(StreamKind.General, 0, "Format");
                    string MinfoXDCAM = MediaInfoLib.Get(StreamKind.General, 0, "Format_Commercial_IfAny");
                    string MinfoVidFormat = MediaInfoLib.Get(StreamKind.Video, 0, "Format");
                    string MinfoBitrate = MediaInfoLib.Get(StreamKind.Video, 0, "BitRate/String");
                    string MinfoWidth = MediaInfoLib.Get(StreamKind.Video, 0, "Width");
                    string MinfoHeight = MediaInfoLib.Get(StreamKind.Video, 0, "Height");
                    string MinfoAspect = MediaInfoLib.Get(StreamKind.Video, 0, "DisplayAspectRatio/String");
                    string MinfoFramerate = MediaInfoLib.Get(StreamKind.Video, 0, "FrameRate/String");
                    string MinfoChromaSub = MediaInfoLib.Get(StreamKind.Video, 0, "ChromaSubsampling");
                    string MinfoScantype = MediaInfoLib.Get(StreamKind.Video, 0, "ScanType/String");
                    string MinfoScanorder = MediaInfoLib.Get(StreamKind.Video, 0, "ScanOrder/String");
                    string MinfoAudioFormat = MediaInfoLib.Get(StreamKind.Audio, 0, "Format");
                    string MinfoAudioBitrate = MediaInfoLib.Get(StreamKind.Audio, 0, "BitRate/String");
                    string MinfoAudioSamprate = MediaInfoLib.Get(StreamKind.Audio, 0, "SamplingRate/String");
                    string MinfoAudiobit = MediaInfoLib.Get(StreamKind.Audio, 0, "BitDepth/String");
                    string MinfoOp1 = MediaInfoLib.Get(StreamKind.General, 0, "Format_Profile");
                    if (durationinfo == "")
                    {
                        durationinfo = "N/A";
                    }
                    string[] row = { fileName, fileExt.TrimStart('.'), result, durationinfo, audiochannel, audiostreams, audioID, videoID, MinfoAspect, "Que" };
                    var listViewItem = new ListViewItem(row);
                    listViewQue.Items.Add(listViewItem);
                    i = i + 1;
                }
                else
                {
                    MessageBox.Show("Not a Video file");
                }
            }
        }
        private void listViewQue_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        // Browse Btn Click
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = BrowseDialog.ShowDialog();    
            if (result == DialogResult.OK)
            {
                TxtTarget.Text = BrowseDialog.SelectedPath.ToString();

            }

        }
        // Btn Add Video
        private void BtnAddVideo_Click(object sender, EventArgs e)
        {

            FileDialog.Filter = "Video files|*.avi;*.mxf;*.mkv;*.mp4;*.webm;*.mpg;*.mpeg;*.mp2;*.mpe;*.mpv;*.3g2;*.mts;*.m2v;*.m4v;*.m4p;*.swf;*.ts;*.3gp;*.ogg;*.mov;*.vob;*.flv;*.mjpeg;*.wmv;*.dav|Audio files|*.mp3;*.m4a;*.wma;*.wav;*.ogg;*.ac3;*.mp2|All files (*.*)|*.*";
            FileDialog.FilterIndex = 1;
            FileDialog.RestoreDirectory = true;
            DialogResult dr = FileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach (String file in FileDialog.FileNames)
                {
                    try
                    {
                        string[] sizes = { "B", "KB", "MB", "GB" };
                        double len = new FileInfo(file).Length;
                        int order = 0;
                        while (len >= 1024 && order + 1 < sizes.Length)
                        {
                            order++;
                            len = len / 1024;
                        }
                        string result = String.Format("{0:0.##} {1}", len, sizes[order]);
                        string fileName = Path.GetFullPath(file);
                        string fileExt = Path.GetExtension(file);
                        MediaInfo MediaInfoLib = new MediaInfo();
                        MediaInfoLib.Open(Path.GetFullPath(file));
                        string durationinfo = MediaInfoLib.Get(StreamKind.General, 0, "Duration/String3");
                        string audiostreams = MediaInfoLib.Count_Get(StreamKind.Audio).ToString();
                        string audiochannel = MediaInfoLib.Get(StreamKind.Audio, 0, "Channel(s)");
                        string audioID = MediaInfoLib.Get(StreamKind.Audio, 0, "ID");
                        string videoID = MediaInfoLib.Get(StreamKind.Video, 0, "ID");
                        string MinfoContainerFormat = MediaInfoLib.Get(StreamKind.General, 0, "Format");
                        string MinfoXDCAM = MediaInfoLib.Get(StreamKind.General, 0, "Format_Commercial_IfAny");
                        string MinfoVidFormat = MediaInfoLib.Get(StreamKind.Video, 0, "Format");
                        string MinfoBitrate = MediaInfoLib.Get(StreamKind.Video, 0, "BitRate/String");
                        string MinfoWidth = MediaInfoLib.Get(StreamKind.Video, 0, "Width");
                        string MinfoHeight = MediaInfoLib.Get(StreamKind.Video, 0, "Height");
                        string MinfoAspect = MediaInfoLib.Get(StreamKind.Video, 0, "DisplayAspectRatio/String");
                        string MinfoFramerate = MediaInfoLib.Get(StreamKind.Video, 0, "FrameRate/String");
                        string MinfoChromaSub = MediaInfoLib.Get(StreamKind.Video, 0, "ChromaSubsampling");
                        string MinfoScantype = MediaInfoLib.Get(StreamKind.Video, 0, "ScanType/String");
                        string MinfoScanorder = MediaInfoLib.Get(StreamKind.Video, 0, "ScanOrder/String");
                        string MinfoAudioFormat = MediaInfoLib.Get(StreamKind.Audio, 0, "Format");
                        string MinfoAudioBitrate = MediaInfoLib.Get(StreamKind.Audio, 0, "BitRate/String");
                        string MinfoAudioSamprate = MediaInfoLib.Get(StreamKind.Audio, 0, "SamplingRate/String");
                        string MinfoAudiobit = MediaInfoLib.Get(StreamKind.Audio, 0, "BitDepth/String");
                        string MinfoOp1 = MediaInfoLib.Get(StreamKind.General, 0, "Format_Profile");
                        if (durationinfo == "")
                        {
                            durationinfo = "N/A";
                        }
                        string[] row = { fileName, fileExt.TrimStart('.'), result, durationinfo, audiochannel, audiostreams, audioID, videoID, MinfoAspect, "Que" };
                        var listViewItem = new ListViewItem(row);
                        listViewQue.Items.Add(listViewItem);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Not open a file(s)!" + ex.Message);
                    }
                }

            }
        }
        // Btn start Events
        private void Start_Click(object sender, EventArgs e)
        {
            if (TxtTarget.Text == "") { MessageBox.Show("You Should Select Target Folder...!!!!", "Booommmm", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (listViewQue.Items.Count == 0) { MessageBox.Show("You Should Add Any Video File...!!!! ", "Booommmm", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else { startevent();}
        }
        public void startevent()
        {
            if (listViewProgress.Items.Count > 0) { MessageBox.Show("Wait for the transcode process to finish...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                ListViewItem temp = listViewQue.Items[0];
                listViewQue.Items.Remove(temp);
                listViewProgress.Items.Add(temp);
                listViewProgress.Items[0].SubItems[9].Text = "% 0";
                CodecSelect();
            }
        }
        // Codec list for Switch case
        public enum CodecState
        {
            X264tff,X264bff,X264p,X265tff,X265bff,X265p,Whatsappexport, XDCAMHDtff, XDCAMHDbff, XDCAMHDp
        }
        public void CodecSelect()
        {
            FromBoxes = "";
            if (listViewProgress.Items[0].SubItems[8].Text == "4:3" || listViewProgress.Items[0].SubItems[8].Text == "16:9")
            {
                FromBoxes = " ";
                fromlistview = "";
                addAduio = false;
            }
            else
            {
                fromlistview = " -filter_complex \"[1:V]scale=w='-1:h=1080'[logo];[0:v][logo]overlay=(main_w-overlay_w)/2:(main_h-overlay_h)/2\" ";
                addAduio = true;
            }
            if (BoxCodec.SelectedIndex == 1)
            {
            if(BoxField.SelectedIndex == 0)
                {
                   state = CodecState.X264tff;
                }
            else if(BoxField.SelectedIndex == 1)
                {
                    state = CodecState.X264bff;
                }
            else if(BoxField.SelectedIndex == 2)
                {
                    state = CodecState.X264p;
                }
                if (BoxRes.SelectedIndex == 0) { FromBoxes = FromBoxes + " "; }
                if (BoxRes.SelectedIndex == 1) { FromBoxes = FromBoxes + " -s 1920x1080  -aspect 16:9 "; }
                if (BoxRes.SelectedIndex == 2) { FromBoxes = FromBoxes + " -s 1280x720  -aspect 16:9 "; }
                if (BoxRes.SelectedIndex == 3) { FromBoxes = FromBoxes + " -s 720x576  -aspect 4:3 "; }
                if (BoxRes.SelectedIndex == 4) { FromBoxes = FromBoxes + " -s 720x480  -aspect 4:3 "; }
                if (BoxFrame.SelectedIndex == 0) { FromBoxes = FromBoxes + ""; }
                if (BoxFrame.SelectedIndex == 1) { FromBoxes = FromBoxes + " -r 25 "; }
                if (BoxFrame.SelectedIndex == 2) { FromBoxes = FromBoxes + " -r 30 "; }
                if (BoxSpeed.SelectedIndex == 0) { FromBoxes = FromBoxes + " -preset veryslow"; }
                if (BoxSpeed.SelectedIndex == 1) { FromBoxes = FromBoxes + " -preset slower"; }
                if (BoxSpeed.SelectedIndex == 2) { FromBoxes = FromBoxes + " -preset slow"; }
                if (BoxSpeed.SelectedIndex == 3) { FromBoxes = FromBoxes + " -preset fast"; }
                if (BoxSpeed.SelectedIndex == 4) { FromBoxes = FromBoxes + " -preset faster"; }
                if (BoxSpeed.SelectedIndex == 5) { FromBoxes = FromBoxes + " -preset veryfast"; }
                if (BoxSpeed.SelectedIndex == 6) { FromBoxes = FromBoxes + " -preset superfast"; }
                if (BoxSpeed.SelectedIndex == 7) { FromBoxes = FromBoxes + " -preset ultrafast"; }
                if (addAduio == true) { FromBoxes = FromBoxes + " -map 1:a? "; };
                FromBoxes = FromBoxes + " -b:v " + BoxBit.SelectedItem.ToString() + "k";
                extension = ".mp4";
            }
            else if (BoxCodec.SelectedIndex == 2)
            {
                if (BoxField.SelectedIndex == 0)
                {
                    state = CodecState.X265tff;
                }
                else if (BoxField.SelectedIndex == 1)
                {
                    state = CodecState.X265bff;
                }
                else if (BoxField.SelectedIndex == 2)
                {
                    state = CodecState.X265p;
                }
                if (BoxRes.SelectedIndex == 0) { FromBoxes = FromBoxes + " "; }
                if (BoxRes.SelectedIndex == 1) { FromBoxes = FromBoxes + " -s 1920x1080  -aspect 16:9 "; }
                if (BoxRes.SelectedIndex == 2) { FromBoxes = FromBoxes + " -s 1280x720  -aspect 16:9 "; }
                if (BoxRes.SelectedIndex == 3) { FromBoxes = FromBoxes + " -s 720x576  -aspect 4:3 "; }
                if (BoxRes.SelectedIndex == 4) { FromBoxes = FromBoxes + " -s 720x480  -aspect 4:3 "; }
                if (BoxFrame.SelectedIndex == 0) { FromBoxes = FromBoxes + ""; }
                if (BoxFrame.SelectedIndex == 1) { FromBoxes = FromBoxes + " -r 25 "; }
                if (BoxFrame.SelectedIndex == 2) { FromBoxes = FromBoxes + " -r 30 "; }
                if (BoxSpeed.SelectedIndex == 0) { FromBoxes = FromBoxes + " -preset veryslow"; }
                if (BoxSpeed.SelectedIndex == 1) { FromBoxes = FromBoxes + " -preset slower"; }
                if (BoxSpeed.SelectedIndex == 2) { FromBoxes = FromBoxes + " -preset slow"; }
                if (BoxSpeed.SelectedIndex == 3) { FromBoxes = FromBoxes + " -preset fast"; }
                if (BoxSpeed.SelectedIndex == 4) { FromBoxes = FromBoxes + " -preset faster"; }
                if (BoxSpeed.SelectedIndex == 5) { FromBoxes = FromBoxes + " -preset veryfast"; }
                if (BoxSpeed.SelectedIndex == 6) { FromBoxes = FromBoxes + " -preset superfast"; }
                if (BoxSpeed.SelectedIndex == 7) { FromBoxes = FromBoxes + " -preset ultrafast"; }
                if (addAduio == true) { FromBoxes = FromBoxes + " -map 1:a? "; };
                FromBoxes = FromBoxes + " -b:v " + BoxBit.SelectedItem.ToString() + "k";
                extension = ".mp4";

            }
            else if (BoxCodec.SelectedIndex == 3)
            {

                state = CodecState.Whatsappexport;
                if (BoxRes.SelectedIndex == 0) { FromBoxes = FromBoxes + " "; }
                if (BoxRes.SelectedIndex == 1) { FromBoxes = FromBoxes + " -s 1920x1080  -aspect 16:9 "; }
                if (BoxRes.SelectedIndex == 2) { FromBoxes = FromBoxes + " -s 1280x720  -aspect 16:9 "; }
                if (BoxRes.SelectedIndex == 3) { FromBoxes = FromBoxes + " -s 720x576  -aspect 4:3 "; }
                if (BoxRes.SelectedIndex == 4) { FromBoxes = FromBoxes + " -s 720x480  -aspect 4:3 "; }
                if (BoxFrame.SelectedIndex == 0) { FromBoxes = FromBoxes + ""; }
                if (BoxFrame.SelectedIndex == 1) { FromBoxes = FromBoxes + " -r 25 "; }
                if (BoxFrame.SelectedIndex == 2) { FromBoxes = FromBoxes + " -r 30 "; }
                if (BoxSpeed.SelectedIndex == 0) { FromBoxes = FromBoxes + " -preset veryslow"; }
                if (BoxSpeed.SelectedIndex == 1) { FromBoxes = FromBoxes + " -preset slower"; }
                if (BoxSpeed.SelectedIndex == 2) { FromBoxes = FromBoxes + " -preset slow"; }
                if (BoxSpeed.SelectedIndex == 3) { FromBoxes = FromBoxes + " -preset fast"; }
                if (BoxSpeed.SelectedIndex == 4) { FromBoxes = FromBoxes + " -preset faster"; }
                if (BoxSpeed.SelectedIndex == 5) { FromBoxes = FromBoxes + " -preset veryfast"; }
                if (BoxSpeed.SelectedIndex == 6) { FromBoxes = FromBoxes + " -preset superfast"; }
                if (BoxSpeed.SelectedIndex == 7) { FromBoxes = FromBoxes + " -preset ultrafast"; }
                if (addAduio == true) { FromBoxes = FromBoxes + " -map 1:a? "; };
                FromBoxes = FromBoxes + " -b:v " + BoxBit.SelectedItem.ToString() + "k";
                extension = ".mp4";
            }
            else if (BoxCodec.SelectedIndex == 0)
            {
                if (BoxField.SelectedIndex == 0)
                {
                    state = CodecState.XDCAMHDtff;
                    if(BoxFrame.SelectedIndex == 0 || BoxFrame.SelectedIndex == 1)
                    {
                        if (listViewProgress.Items[0].SubItems[5].Text == "1" && listViewProgress.Items[0].SubItems[4].Text != "1" && listViewProgress.Items[0].SubItems[4].Text != "0")
                        {
                            if (addAduio == true) { FromBoxes = FromBoxes + " -filter_complex \"[1:a:0]pan=1c|c0=c0[FL];[1:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 25 -vtag xd5c -s 1920x1080  -aspect 16:9 "; }
                            else { FromBoxes = FromBoxes + " -filter_complex \"[0:a:0]pan=1c|c0=c0[FL];[0:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 25 -vtag xd5c -s 1920x1080  -aspect 16:9 "; }
                               
                        }
                        else
                        {
                            FromBoxes = FromBoxes + " -map 0:v:0 -map 0:a? -r 25 -vtag xd5c -s 1920x1080  -aspect 16:9 ";
                        }
                           
                    }
                    else
                    {
                        if (listViewProgress.Items[0].SubItems[5].Text == "1" && listViewProgress.Items[0].SubItems[4].Text != "1" && listViewProgress.Items[0].SubItems[4].Text != "0")
                        {
                            if (addAduio == true) { FromBoxes = FromBoxes + " -filter_complex \"[1:a:0]pan=1c|c0=c0[FL];[1:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 30 -vtag xd5b -s 1920x1080  -aspect 16:9 "; }
                            else { FromBoxes = FromBoxes + " -filter_complex \"[0:a:0]pan=1c|c0=c0[FL];[0:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 30 -vtag xd5b -s 1920x1080  -aspect 16:9 "; }
                        }
                        else
                        {
                            FromBoxes = FromBoxes + " -map 0:v:0 -map 0:a? -r 30 -vtag xd5b -s 1920x1080  -aspect 16:9 ";
                        }                           
                    }
                }
                else if (BoxField.SelectedIndex == 1)
                {
                    state = CodecState.XDCAMHDbff;
                    if (BoxFrame.SelectedIndex == 0 || BoxFrame.SelectedIndex == 1)
                    {
                        if (listViewProgress.Items[0].SubItems[5].Text == "1" && listViewProgress.Items[0].SubItems[4].Text != "1" && listViewProgress.Items[0].SubItems[4].Text != "0")
                        {
                            if (addAduio == true) { FromBoxes = FromBoxes + " -filter_complex \"[1:a:0]pan=1c|c0=c0[FL];[1:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 25 -vtag xd5c -s 1920x1080  -aspect 16:9 "; }
                            else { FromBoxes = FromBoxes + " -filter_complex \"[0:a:0]pan=1c|c0=c0[FL];[0:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 25 -vtag xd5c -s 1920x1080  -aspect 16:9 "; }
                        }
                        else
                        {
                            FromBoxes = FromBoxes + " -map 0:v:0 -map 0:a? -r 25 -vtag xd5c -s 1920x1080  -aspect 16:9 ";
                        }                      
                    }
                    else
                    {
                        if (listViewProgress.Items[0].SubItems[5].Text == "1" && listViewProgress.Items[0].SubItems[4].Text != "1" && listViewProgress.Items[0].SubItems[4].Text != "0")
                        {
                            if (addAduio == true) { FromBoxes = FromBoxes + " -filter_complex \"[1:a:0]pan=1c|c0=c0[FL];[1:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 30 -vtag xd5b -s 1920x1080  -aspect 16:9 "; }
                            else { FromBoxes = FromBoxes + " -filter_complex \"[0:a:0]pan=1c|c0=c0[FL];[0:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 30 -vtag xd5b -s 1920x1080  -aspect 16:9 "; }
                        }
                        else
                        {
                            FromBoxes = FromBoxes + " -map 0:v:0 -map 0:a? -r 30 -vtag xd5b -s 1920x1080  -aspect 16:9 ";
                        }                           
                    }
                }
                else if (BoxField.SelectedIndex == 2)
                {
                    state = CodecState.XDCAMHDp;
                    if (BoxFrame.SelectedIndex == 0 || BoxFrame.SelectedIndex == 1)
                    {
                        if (listViewProgress.Items[0].SubItems[5].Text == "1" && listViewProgress.Items[0].SubItems[4].Text != "1" && listViewProgress.Items[0].SubItems[4].Text != "0")
                        {
                            if (addAduio == true) { FromBoxes = FromBoxes + " -filter_complex \"[1:a:0]pan=1c|c0=c0[FL];[1:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 25 -vtag xd5e -s 1920x1080  -aspect 16:9 "; }
                            else { FromBoxes = FromBoxes + " -filter_complex \"[0:a:0]pan=1c|c0=c0[FL];[0:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 25 -vtag xd5e -s 1920x1080  -aspect 16:9 "; }
                        }
                        else
                        {
                            FromBoxes = FromBoxes + " -map 0:v:0 -map 0:a? -r 25 -vtag xd5e -s 1920x1080  -aspect 16:9 ";
                        }                           
                    }
                    else
                    {
                        if (listViewProgress.Items[0].SubItems[5].Text == "1" && listViewProgress.Items[0].SubItems[4].Text != "1" && listViewProgress.Items[0].SubItems[4].Text != "0")
                        {
                            if (addAduio == true) { FromBoxes = FromBoxes + " -filter_complex \"[1:a:0]pan=1c|c0=c0[FL];[1:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 30 -vtag xd5f -s 1920x1080  -aspect 16:9 "; }
                            else { FromBoxes = FromBoxes + " -filter_complex \"[0:a:0]pan=1c|c0=c0[FL];[0:a:0]pan=1c|c0=c1[FR]\" -map 0:v:0 -map \"[FL]\" -map \"[FR]\" -r 30 -vtag xd5f -s 1920x1080  -aspect 16:9 "; }
                        }
                        else
                        {
                            FromBoxes = FromBoxes + " -map 0:v:0 -map 0:a? -r 30 -vtag xd5f -s 1920x1080  -aspect 16:9 ";
                        }                           
                    }
                }
                extension = ".mxf";
            }
            switch (state) 
            {
                case CodecState.X264tff:
                    ffCode = ReadCodectList.X264tff;
                    ffCode = fromlistview + ffCode + FromBoxes;
                    break;
                case CodecState.X264bff:
                    ffCode = ReadCodectList.X264bff;
                    ffCode = fromlistview + ffCode + FromBoxes;
                    break;
                case CodecState.X264p:
                    ffCode = ReadCodectList.X264p;
                    ffCode = fromlistview + ffCode + FromBoxes;
                    break;
                case CodecState.X265tff:
                    ffCode = ReadCodectList.X265tff;
                    ffCode = fromlistview + ffCode + FromBoxes;
                    break;
                case CodecState.X265bff:
                    ffCode = ReadCodectList.X265bff;
                    ffCode = fromlistview + ffCode + FromBoxes;
                    break;
                case CodecState.X265p:
                    ffCode = ReadCodectList.X265p;
                    ffCode = fromlistview + ffCode + FromBoxes;
                    break;
                case CodecState.Whatsappexport:
                    ffCode = ReadCodectList.WhatsappExport;
                    ffCode = fromlistview + ffCode + FromBoxes;
                    break;
                case CodecState.XDCAMHDtff:
                    ffCode = ReadCodectList.XDCAMHDtff;
                    ffCode = fromlistview + ffCode + FromBoxes ;
                    break;
                case CodecState.XDCAMHDbff:
                    ffCode = ReadCodectList.XDCAMHDbff;
                    ffCode = fromlistview + ffCode + FromBoxes;
                    break;
                case CodecState.XDCAMHDp:
                    ffCode = ReadCodectList.XDCAMHDp;
                    ffCode = fromlistview + ffCode + FromBoxes;
                    break;
                default:
                    break;
            }
            PrepareCoder();

        }

        // starting FFprobe  for media details and creating log file.
        public void PrepareCoder()
        {
            try
            {
                if (listViewProgress.Items.Count > 0)
                {
                    listViewProgress.Items[0].Selected = true;
                    listViewProgress.Select();                   
                }
                else
                {
                    MessageBox.Show("Does not added any Video...!!!");
                }
                string fileName = Path.GetFileName(listViewProgress.SelectedItems.ToString());
                string fileFull = listViewProgress.Items[0].Text;
                string simpleFileName = Path.GetFileNameWithoutExtension(listViewProgress.Items[0].Text);
                Process Probe = new Process();
                Probe.StartInfo.FileName = "cmd.exe";
                Probe.StartInfo.WorkingDirectory = System.Environment.CurrentDirectory;
                var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                path = path + "\\Logs";
                string infoFileName = "" + simpleFileName + "_" + DateTime.Now.ToString("ddMMyy_HHmmss") + "";
                logfilename = "" + simpleFileName + "_" + DateTime.Now.ToString("ddMMyy_HHmmss") + "";
                logpath = path;
                Probe.StartInfo.Arguments = "/C ffprobe.exe -show_streams -i \"" + fileFull + "\"" + "2>" + "\"" + path + "\\" + infoFileName + "_info.txt";
                Probe.StartInfo.CreateNoWindow = true;
                Probe.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Probe.Start();
                Probe.WaitForExit();
                foreach (string duration in System.IO.File.ReadLines(path + @"\" + infoFileName + "_info.txt"))
                {
                    if (duration.Contains("Duration:"))
                    {
                        string pat = @"\: ([^,]*)";
                        Regex r = new Regex(pat, RegexOptions.IgnoreCase);
                        Match m = r.Match(duration);
                        //Time split
                        string duration2 = m.ToString();
                        char[] arr = new char[] { ':', ' ' };
                        duration2 = duration2.TrimStart(arr);
                        string s2 = Regex.Replace(duration2, ".\\d{2}$", "");
                        var values = Regex.Split(s2, @"[\s,:]+");
                        if (s2 != "N/A")
                        {
                            int ora = int.Parse(values[0]);
                            int perc = int.Parse(values[1]);
                            int mp = int.Parse(values[2]);
                            int osszeg = ora * 3600 + 60 * perc + mp;
                            progressBar1.Maximum = osszeg;
                        }
                        //Unknown duration time
                        else
                        {
                            progressBar1.Style = ProgressBarStyle.Marquee;
                            progressBar1.MarqueeAnimationSpeed = 50;
                            var prog = Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance;
                            prog.SetProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Indeterminate);
                            listViewProgress.Items[0].SubItems[7].Text = "N/A";
                        }
                    }
                }

            }
            catch (Exception Warning)
            {
                MessageBox.Show("Problem : " + Warning);
            }

            FFCoder();
        }
        public void FFCoder()
        {
            string fileName = Path.GetFileName(listViewProgress.SelectedItems.ToString());
            string fileFull = listViewProgress.Items[0].Text;
            string simpleFileName = Path.GetFileNameWithoutExtension(listViewProgress.Items[0].Text);
            Process myCoding = new Process();
            myCoding.StartInfo.FileName = "cmd.exe";
            myCoding.StartInfo.WorkingDirectory = System.Environment.CurrentDirectory;
            if (listViewProgress.Items[0].SubItems[8].Text == "4:3" || listViewProgress.Items[0].SubItems[8].Text == "16:9")
            {
                myCoding.StartInfo.Arguments = "/C ffmpeg.exe -i \"" + fileFull + "\" " + ffCode + " \"" + TxtTarget.Text + "\\" + simpleFileName + extension + "\"" + " 2>" + "\"" + logpath + "\\" + logfilename + "_Process.txt";
            }
            else
            {
                myCoding.StartInfo.Arguments = "/C ffmpeg.exe -i Black.png -i \"" + fileFull + "\" " + ffCode + " \"" + TxtTarget.Text + "\\" + simpleFileName + extension + "\"" + " 2>" + "\"" + logpath + "\\" + logfilename + "_Process.txt";
            }
               
            myCoding.StartInfo.CreateNoWindow = true;
            myCoding.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myCoding.EnableRaisingEvents = true;
            myCoding.Exited += new EventHandler(myCoding_Exited);
            myCoding.Start();
            progressBar1.Visible = true;
            progressBar1.Show();
            System.Threading.Thread.Sleep(2000);
            timer1.Enabled = true;
        }

        private void myCoding_Exited(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (listViewProgress.Items.Count > 0)
                {
                    listViewProgress.Items.RemoveAt(0);
                }
                timer1.Stop();
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Increment(100);
                var prog = Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance;
                prog.SetProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Normal);
                prog.SetProgressValue(progressBar1.Value, progressBar1.Maximum);
                if (listViewProgress.Items.Count > 0)
                {
                    listViewProgress.Items[0].SubItems[7].Text = "%100";
                }
                if (listViewQue.Items.Count > 0)
                {
                    startevent();
                   
                }
                else
                {
                    MessageBox.Show("Encoding Finished!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConsoleTxt.Text = "Finished";
                }
            });
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            string last = "";
            try
            {

                siof.Copy("" + logpath + "\\" + logfilename + "_Process.txt", "" + logpath + "\\" + logfilename + "_ProcessLast.txt", true);
            }
            catch (Exception Warning)
            {

                MessageBox.Show(Warning.Message, "Execpiton");
            }

            try
            {
                last = File.ReadAllLines("" + logpath + "\\" + logfilename + "_ProcessLast.txt").Last();
            }
            catch (Exception War)
            {
                string Warn = War.ToString();
                //MessageBox.Show(hata.Message);
            }
            ConsoleTxt.Text = last;
            if (last.Contains("time="))
            {
                string pat = @"\d{2}:\d{2}:\d{2}";
                Regex r = new Regex(pat, RegexOptions.IgnoreCase);
                Match m = r.Match(last);
                string last2 = m.ToString();
                //Progressbar
                if (progressBar1.Style != ProgressBarStyle.Marquee)
                {
                    char[] arr = new char[] { ':', ' ' };
                    last2 = last2.TrimStart(arr);
                    var values = Regex.Split(last2, @"[\s,:]+");
                    int ora = int.Parse(values[0]);
                    int perc = int.Parse(values[1]);
                    int mp = int.Parse(values[2]);
                    int osszeg2 = ora * 3600 + 60 * perc + mp;
                    progressBar1.Value = osszeg2;
                    var prog = Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance;
                    prog.SetProgressState(Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Normal);
                    prog.SetProgressValue(progressBar1.Value, progressBar1.Maximum);
                    //Percent
                    int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                    listViewProgress.Items[0].SubItems[9].Text = "%" + percent.ToString();
                }
                else
                {
                    listViewProgress.Items[0].SubItems[9].Text = "N/A";
                }

            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:murat@muratdemirci.com.tr", linkLabel1.Text);
        }

        private void BoxCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(BoxCodec.SelectedIndex == 3)
            {
                MessageBox.Show("Video duration must be less than 1.5 minutes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BoxField.Enabled = false;
                BoxRes.Enabled = true;
                BoxBit.Enabled = true;
                BoxBit.SelectedIndex = 0;
            }
            else if (BoxCodec.SelectedIndex==0)
            {
                BoxRes.Enabled = false;
                BoxBit.Enabled = false;
                BoxField.Enabled = true;
            }
            else
            {
                BoxField.Enabled = true;
                BoxRes.Enabled = true;
                BoxBit.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            ini.IniWriteValue("Settings", "DestinationPath", TxtTarget.Text);
            ini.IniWriteValue("Settings", "BoxCodec", BoxCodec.SelectedIndex.ToString());
            ini.IniWriteValue("Settings", "BoxBit", BoxBit.SelectedIndex.ToString());
            ini.IniWriteValue("Settings", "BoxRes", BoxRes.SelectedIndex.ToString());
            ini.IniWriteValue("Settings", "BoxField", BoxField.SelectedIndex.ToString());
            ini.IniWriteValue("Settings", "BoxSpeed", BoxSpeed.SelectedIndex.ToString());
            ini.IniWriteValue("Settings", "BoxFrame", BoxFrame.SelectedIndex.ToString());
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Process[] prs = Process.GetProcesses();


            foreach (Process pr in prs)
            {
                if (pr.ProcessName == "ffmpeg")
                {

                    pr.Kill();
                    listViewProgress.Items.Clear();
                    MessageBox.Show("Encoding aborted from user!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listViewQue.SelectedItems.Count > 0)
            {
                try
                {
                    listViewQue.BeginUpdate();
                    foreach (ListViewItem item in this.listViewQue.SelectedItems)
                    {
                        this.listViewQue.Items.Remove(item);
                    }
                }
                finally
                {
                    this.listViewQue.EndUpdate();
                }
            }
            else
            {
                MessageBox.Show("Please Select Item", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
