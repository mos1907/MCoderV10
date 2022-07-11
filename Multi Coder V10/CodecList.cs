using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ini;

namespace Multi_Coder_V10
{
    class CodecList
    {
        public string X264tff;
        public string X264bff;
        public string X264p;
        public string X265tff;
        public string X265bff;
        public string X265p;
        public string WhatsappExport;
        public string XDCAMHDtff;
        public string XDCAMHDbff;
        public string XDCAMHDp;
        public string XDCAMHD;
        public string XDCAMcomplex;
        public string AudioToVideo;
        public string Black;
        public string Destination;
        public int BoxCodec;
        public int BoxBit;
        public int BoxRes;
        public int BoxField;
        public int BoxSpeed;
        public int BoxFrame;
        IniFile ini = new IniFile(Environment.CurrentDirectory + "\\Config.ini");

        public void ReadCodec()
        {
            X264tff = " -y -threads 16 -vcodec libx264 -pix_fmt yuv420p -map 0:v:0 -map 0:a?  -c:a libfdk_aac -b:a 128k -flags +ilme+ildct -x264opts tff=1 -f mp4";
            X264bff = " -y -threads 16 -vcodec libx264 -pix_fmt yuv420p -map 0:v:0 -map 0:a?  -c:a libfdk_aac -b:a 128k -flags +ilme+ildct -x264opts bff=1 -f mp4";
            X264p = " -y -threads 16 -vcodec libx264 -pix_fmt yuv420p -map 0:v:0 -map 0:a?  -c:a libfdk_aac -b:a 128k -field_order progressive -f mp4";
            X265tff = " -y -threads 16 -vcodec libx265 -pix_fmt yuv420p -map 0:v:0 -map 0:a? -c:a libfdk_aac -b:a 128k -flags +ilme+ildct -x265-params tff=1 -f mp4";
            X265bff = " -y -threads 16 -vcodec libx265 -pix_fmt yuv420p -map 0:v:0 -map 0:a?  -c:a libfdk_aac -b:a 128k -field_order bb -f mp4";
            X265p = " -y -threads 16 -vcodec libx265 -pix_fmt yuv420p -map 0:v:0 -map 0:a?   -c:a libfdk_aac -b:a 128k -field_order progressive -f mp4";
            WhatsappExport = " -y -threads 16 -vcodec libx264 -pix_fmt yuv420p -flags +ilme+ildct -x264opts tff=1  -profile:v main -level 3.1 -r 25 -ac 2 -f mp4";
            XDCAMHDtff = "-y  -threads 16 -f lavfi -i anullsrc=1 -vcodec mpeg2video -pix_fmt yuv422p -field_order tt -top 1 -flags +ildct+ilme -alternate_scan 1  -c:a pcm_s24le -ar 48000 -ac 1  -rc_max_vbv_use 1 -rc_min_vbv_use 1  -color_range 1 -color_primaries 1  -color_trc 1 -colorspace 1 -non_linear_quant 1 -dc 11 -intra_vlc 1 -qmin 1 -lmin \"1*QP2LAMBDA\" -qmax 28 -lmax \"56*QP2LAMBDA\"  -b:v 50000000  -minrate 50000000 -maxrate 50000000 -minrate 50000000 -bufsize 17825792 -metadata creation_time=now  -g 12 -bf 2 -timecode 00:00:00:00  -intra_matrix 8,17,17,19,17,19,21,21,21,21,21,21,23,22,23,24,24,24,24,24,24,24,25,25,25,26,26,26,29,29,29,26,26,26,25,25,27,27,28,29,29,29,31,32,32,31,31,30,30,33,33,34,34,34,38,38,37,37,43,43,44,50,50,58  -inter_matrix 16,17,17,18,18,18,19,19,19,19,20,20,20,20,20,21,21,21,21,21,21,22,22,22,22,22,22,22,23,23,23,23,23,23,23,23,24,24,24,25,24,24,24,25,26,26,26,26,25,27,27,27,27,27,28,28,28,28,30,30,30,31,31,33 -f mxf  -shortest  ";
            XDCAMHDbff = "-y -threads 16 -f lavfi -i anullsrc=1 -vcodec mpeg2video -pix_fmt yuv422p -c:a pcm_s24le -ar 48000 -ac 1  -rc_max_vbv_use 1 -rc_min_vbv_use 1  -color_range 1 -color_primaries 1  -color_trc 1 -colorspace 1 -non_linear_quant 1 -dc 11 -intra_vlc 1 -qmin 1 -lmin \"1*QP2LAMBDA\" -qmax 28 -lmax \"56*QP2LAMBDA\"  -b:v 50000000  -minrate 50000000 -maxrate 50000000 -minrate 50000000 -bufsize 17825792 -metadata creation_time=now  -field_order bb   -alternate_scan 1 -g 12 -bf 2 -timecode 00:00:00:00  -intra_matrix 8,17,17,19,17,19,21,21,21,21,21,21,23,22,23,24,24,24,24,24,24,24,25,25,25,26,26,26,29,29,29,26,26,26,25,25,27,27,28,29,29,29,31,32,32,31,31,30,30,33,33,34,34,34,38,38,37,37,43,43,44,50,50,58  -inter_matrix 16,17,17,18,18,18,19,19,19,19,20,20,20,20,20,21,21,21,21,21,21,22,22,22,22,22,22,22,23,23,23,23,23,23,23,23,24,24,24,25,24,24,24,25,26,26,26,26,25,27,27,27,27,27,28,28,28,28,30,30,30,31,31,33 -f mxf -shortest  ";
            XDCAMHDp = "  -y -threads 16 -f lavfi -i anullsrc=1 -vcodec mpeg2video -pix_fmt yuv422p -c:a pcm_s24le -ar 48000 -ac 1  -rc_max_vbv_use 1 -rc_min_vbv_use 1  -color_range 1 -color_primaries 1  -color_trc 1 -colorspace 1 -non_linear_quant 1 -dc 11 -intra_vlc 1 -qmin 1 -lmin \"1 * QP2LAMBDA\" -qmax 28 -lmax \"56 * QP2LAMBDA\"  -b:v 50000000  -minrate 50000000 -maxrate 50000000 -minrate 50000000 -bufsize 17825792 -metadata creation_time=now  -g 12 -bf 2 -timecode 00:00:00:00  -intra_matrix 8,17,17,19,17,19,21,21,21,21,21,21,23,22,23,24,24,24,24,24,24,24,25,25,25,26,26,26,29,29,29,26,26,26,25,25,27,27,28,29,29,29,31,32,32,31,31,30,30,33,33,34,34,34,38,38,37,37,43,43,44,50,50,58  -inter_matrix 16,17,17,18,18,18,19,19,19,19,20,20,20,20,20,21,21,21,21,21,21,22,22,22,22,22,22,22,23,23,23,23,23,23,23,23,24,24,24,25,24,24,24,25,26,26,26,26,25,27,27,27,27,27,28,28,28,28,30,30,30,31,31,33 -f mxf -shortest ";
            XDCAMHD = " -y -threads 16 -f lavfi -i anullsrc=1 -vcodec mpeg2video -pix_fmt yuv422p  -c:a pcm_s24le -ar 48000 -ac 1  -rc_max_vbv_use 1 -rc_min_vbv_use 1  -color_range 1 -color_primaries 1  -color_trc 1 -colorspace 1 -non_linear_quant 1 -dc 11 -intra_vlc 1 -qmin 1 -lmin \"1 * QP2LAMBDA\" -qmax 28 -lmax \"56 * QP2LAMBDA\"  -b:v 50000000  -minrate 50000000 -maxrate 50000000 -minrate 50000000 -bufsize 17825792 -metadata creation_time=now  -g 12 -bf 2 -timecode 00:00:00:00  -intra_matrix 8,17,17,19,17,19,21,21,21,21,21,21,23,22,23,24,24,24,24,24,24,24,25,25,25,26,26,26,29,29,29,26,26,26,25,25,27,27,28,29,29,29,31,32,32,31,31,30,30,33,33,34,34,34,38,38,37,37,43,43,44,50,50,58  -inter_matrix 16,17,17,18,18,18,19,19,19,19,20,20,20,20,20,21,21,21,21,21,21,22,22,22,22,22,22,22,23,23,23,23,23,23,23,23,24,24,24,25,24,24,24,25,26,26,26,26,25,27,27,27,27,27,28,28,28,28,30,30,30,31,31,33 -f mxf -shortest ";
            XDCAMcomplex = "  ";

            if (ini.IniReadValue("Settings", "DestinationPath") != null)
            {
                Destination = ini.IniReadValue("Settings", "DestinationPath");
                BoxCodec = Convert.ToInt32(ini.IniReadValue("Settings", "BoxCodec"));
                BoxBit = Convert.ToInt32(ini.IniReadValue("Settings", "BoxBit"));
                BoxRes = Convert.ToInt32(ini.IniReadValue("Settings", "BoxRes"));              
                BoxField = Convert.ToInt32(ini.IniReadValue("Settings", "BoxField"));
                BoxSpeed = Convert.ToInt32(ini.IniReadValue("Settings", "BoxSpeed"));
                BoxFrame = Convert.ToInt32(ini.IniReadValue("Settings", "BoxFrame"));

            }
        }
    }
}
