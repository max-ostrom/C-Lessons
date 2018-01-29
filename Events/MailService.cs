using System;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine("MailService send an email " + args.video.Title);
        }
    }
}
