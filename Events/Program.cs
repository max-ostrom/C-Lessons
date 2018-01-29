using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video();
            video.Title = "Video 1";
            var videoEncoder = new VideoEncoder();
            var mailSevice = new MailService();
            var logService = new LogService();
            videoEncoder.VideoEncoded += mailSevice.OnVideoEncoded;
            videoEncoder.VideoEncoded += logService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
