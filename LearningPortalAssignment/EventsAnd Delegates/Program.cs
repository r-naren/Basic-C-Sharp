using System;

namespace EventsAnd_Delegates
{
    class Program{
        public static void Main(string[] args)
        {
            var video = new Video(){Title="Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //reference
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //reference

            videoEncoder.Encode(video); 
        
        }
    }
    
}