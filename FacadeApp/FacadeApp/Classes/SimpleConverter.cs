﻿using System;

namespace FacadeApp
{
    class SimpleConverter
    {
        public void Convert(string filename, string format)
        {
            VideoFile videoFile = new VideoFile(filename);
            Codec codec;
            switch (format)
            {
                case "mp4":
                    codec = new MPEG4Codec();
                    break;
                case "ogg":
                    codec = new OGGCodec();
                    break;
                default:
                    throw new FormatException($"Format \"{format}\" is not supported. Only \"mp4\" or \"ogg\"");
            }
            VideoCoverter videoCoverter = new VideoCoverter();
            int res = videoCoverter.Convert(videoFile, codec);
            if (res == 0)
            {
                Console.WriteLine("Conversion successful");
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
        }
    }
}
