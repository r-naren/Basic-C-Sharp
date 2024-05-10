using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAnd_Delegates
{
    public class VideoEventArgs : EventArgs{
        public Video Video { get; set; }
        
        
    }
    public class VideoEncoder
    {
        // define a delgate
        //define an event based on that delegate
        //Raise the event

        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding video..");
            Thread.Sleep(4000);
            OnVideoEncoded(video);

        }
        //protected virtual void naming convention
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs(){Video = video});
            }
        }
    }
}