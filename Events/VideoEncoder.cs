﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object sender, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        // or 
        //public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ..");

            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs(video));
            }
        }
    }
}
