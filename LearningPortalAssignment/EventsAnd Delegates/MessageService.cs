using System;
namespace EventsAnd_Delegates{
    public class MessageService{
        public void OnVideoEncoded(Object source, VideoEventArgs args){
            Console.WriteLine($"Text " +  args.Video.Title);
        }
    }
}