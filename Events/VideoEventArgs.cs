using System;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public VideoEventArgs(Video video)
        {
            this.video = video;
        }
        public Video video  { get; set; }
    }
}