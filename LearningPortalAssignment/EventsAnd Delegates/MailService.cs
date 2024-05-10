using System;
namespace EventsAnd_Delegates{
    public class MailService{
        public void OnVideoEncoded(Object source, VideoEventArgs e){
            Console.WriteLine($"Mail..."+ e.Video.Title);
        }
    }
}