﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qiniu.Util
{
    public abstract class AVThumbFormats
    {
        private AVThumbFormats() { }
        public const string _3g2 = "3g2"; // 3GP2 (3GPP2 file format)
        public const string _3gp = "3gp"; // 3GP (3GPP file format)
        public const string a64 = "a64"; // a64 video for Commodore 64
        public const string ac3 = "ac3"; // raw AC-3
        public const string adts = "adts"; // ADTS AAC (Advanced Audio Coding)
        public const string adx = "adx"; // CRI ADX
        public const string aiff = "aiff"; // Audio IFF
        public const string alaw = "alaw"; // PCM A-law
        public const string amr = "amr"; // 3GPP AMR
        public const string asf = "asf"; // ASF (Advanced / Active Streaming Format)
        public const string asf_stream = "asf_stream"; // ASF (Advanced / Active Streaming Format)
        public const string ass = "ass"; // SSA (SubStation Alpha) subtitle
        public const string ast = "ast"; // AST (Audio Stream)
        public const string au = "au"; // Sun AU
        public const string avi = "avi"; // AVI (Audio Video Interleaved)
        public const string avm2 = "avm2"; // SWF (ShockWave Flash) (AVM2)
        public const string bit = "bit"; // G.729 BIT file format
        public const string caf = "caf"; // Apple CAF (Core Audio Format)
        public const string cavsvideo = "cavsvideo"; // raw Chinese AVS (Audio Video Standard) video
        public const string crc = "crc"; // CRC testing
        public const string data = "data"; // raw data
        public const string daud = "daud"; // D-Cinema audio
        public const string dirac = "dirac"; // raw Dirac
        public const string dnxhd = "dnxhd"; // raw DNxHD (SMPTE VC-3)
        public const string dts = "dts"; // raw DTS
        public const string dv = "dv"; // DV (Digital Video)
        public const string dvd = "dvd"; // MPEG-2 PS (DVD VOB)
        public const string eac3 = "eac3"; // raw E-AC-3
        public const string f32be = "f32be"; // PCM 32-bit floating-point big-endian
        public const string f32le = "f32le"; // PCM 32-bit floating-point little-endian
        public const string f4v = "f4v"; // F4V Adobe Flash Video
        public const string f64be = "f64be"; // PCM 64-bit floating-point big-endian
        public const string f64le = "f64le"; // PCM 64-bit floating-point little-endian
        public const string ffm = "ffm"; // FFM (FFserver live feed)
        public const string ffmetadata = "ffmetadata"; // FFmpeg metadata in text
        public const string filmstrip = "filmstrip"; // Adobe Filmstrip
        public const string flac = "flac"; // raw FLAC
        public const string flv = "flv"; // FLV (Flash Video)
        public const string framecrc = "framecrc"; // framecrc testing
        public const string framemd5 = "framemd5"; // Per-frame MD5 testing
        public const string g722 = "g722"; // raw G.722
        public const string g723_1 = "g723_1"; // raw G.723.1
        public const string gif = "gif"; // GIF Animation
        public const string gxf = "gxf"; // GXF (General eXchange Format)
        public const string h261 = "h261"; // raw H.261
        public const string h263 = "h263"; // raw H.263
        public const string h264 = "h264"; // raw H.264 video
        public const string hls = "hls"; // Apple HTTP Live Streaming
        public const string ico = "ico"; // Microsoft Windows ICO
        public const string ilbc = "ilbc"; // iLBC storage
        public const string image2 = "image2"; // image2 sequence
        public const string image2pipe = "image2pipe"; // piped image2 sequence
        public const string ipod = "ipod"; // iPod H.264 MP4 (MPEG-4 Part 14)
        public const string ircam = "ircam"; // Berkeley/IRCAM/CARL Sound Format
        public const string ismv = "ismv"; // ISMV/ISMA (Smooth Streaming)
        public const string ivf = "ivf"; // On2 IVF
        public const string jacosub = "jacosub"; // JACOsub subtitle format
        public const string latm = "latm"; // LOAS/LATM
        public const string m4v = "m4v"; // raw MPEG-4 video
        public const string matroska = "matroska"; // Matroska
        public const string md5 = "md5"; // MD5 testing
        public const string microdvd = "microdvd"; // MicroDVD subtitle format
        public const string mjpeg = "mjpeg"; // raw MJPEG video
        public const string mkvtimestamp_v2 = "mkvtimestamp_v2"; // extract pts as timecode v2 format, as defined by mkvtoolnix
        public const string mlp = "mlp"; // raw MLP
        public const string mmf = "mmf"; // Yamaha SMAF
        public const string mov = "mov"; // QuickTime / MOV
        public const string mp2 = "mp2"; // MP2 (MPEG audio layer 2)
        public const string mp3 = "mp3"; // MP3 (MPEG audio layer 3)
        public const string mp4 = "mp4"; // MP4 (MPEG-4 Part 14)
        public const string mpeg = "mpeg"; // MPEG-1 Systems / MPEG program stream
        public const string mpeg1video = "mpeg1video"; // raw MPEG-1 video
        public const string mpeg2video = "mpeg2video"; // raw MPEG-2 video
        public const string mpegts = "mpegts"; // MPEG-TS (MPEG-2 Transport Stream)
        public const string mpjpeg = "mpjpeg"; // MIME multipart JPEG
        public const string mulaw = "mulaw"; // PCM mu-law
        public const string mxf = "mxf"; // MXF (Material eXchange Format)
        public const string mxf_d10 = "mxf_d10"; // MXF (Material eXchange Format) D-10 Mapping
        public const string nut = "nut"; // NUT
        public const string ogg = "ogg"; // Ogg
        public const string oma = "oma"; // Sony OpenMG audio
        public const string psp = "psp"; // PSP MP4 (MPEG-4 Part 14)
        public const string rawvideo = "rawvideo"; // raw video
        public const string rm = "rm"; // RealMedia
        public const string roq = "roq"; // raw id RoQ
        public const string rso = "rso"; // Lego Mindstorms RSO
        public const string rtp = "rtp"; // RTP output
        public const string rtsp = "rtsp"; // RTSP output
        public const string s16be = "s16be"; // PCM signed 16-bit big-endian
        public const string s16le = "s16le"; // PCM signed 16-bit little-endian
        public const string s24be = "s24be"; // PCM signed 24-bit big-endian
        public const string s24le = "s24le"; // PCM signed 24-bit little-endian
        public const string s32be = "s32be"; // tPCM signed 32-bit big-endian
        public const string s32le = "s32le"; // PCM signed 32-bit little-endian
        public const string s8 = "s8"; // PCM signed 8-bit
        public const string sap = "sap"; // SAP output
        public const string segment = "segment"; // segment
        public const string smjpeg = "smjpeg"; // Loki SDL MJPEG
        public const string smoothstreaming = "smoothstreaming"; // Smooth Streaming Muxer
        public const string sox = "sox"; // SoX native
        public const string spdif = "spdif"; // IEC 61937 (used on S/PDIF - IEC958)
        public const string srt = "srt"; // SubRip subtitle
        public const string stream_segment = "stream_segment"; // streaming segment muxer
        public const string ssegment = "ssegment"; // streaming segment muxer
        public const string svcd = "svcd"; // MPEG-2 PS (SVCD)
        public const string swf = "swf"; // SWF (ShockWave Flash)
        public const string tee = "tee"; // Multiple muxer tee
        public const string truehd = "truehd"; // raw TrueHD
        public const string u16be = "u16be"; // PCM unsigned 16-bit big-endian
        public const string u16le = "u16le"; // PCM unsigned 16-bit little-endian
        public const string u24be = "u24be"; // PCM unsigned 24-bit big-endian
        public const string u24le = "u24le"; // PCM unsigned 24-bit little-endian
        public const string u32be = "u32be"; // PCM unsigned 32-bit big-endian
        public const string u32le = "u32le"; // PCM unsigned 32-bit little-endian
        public const string u8 = "u8"; // PCM unsigned 8-bit
        public const string vc1 = "vc1"; // raw VC-1 video
        public const string vc1test = "vc1test"; // VC-1 test bitstream
        public const string vcd = "vcd"; // MPEG-1 Systems / MPEG program stream (VCD)
        public const string vob = "vob"; // MPEG-2 PS (VOB)
        public const string voc = "voc"; // Creative Voice
        public const string w64 = "w64"; // Sony Wave64
        public const string wav = "wav"; // WAV / WAVE (Waveform Audio)
        public const string webm = "webm"; // Matroska / WebM
        public const string webvtt = "webvtt"; // WebVTT subtitle
        public const string wtv = "wtv"; // Windows Television (WTV)
        public const string wv = "wv"; // raw WavPack
        public const string yuv4mpegpipe = "yuv4mpegpipe"; // YUV4MPEG pipe
    }
}
