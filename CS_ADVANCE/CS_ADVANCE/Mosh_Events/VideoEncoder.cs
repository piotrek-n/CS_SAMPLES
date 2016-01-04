using System;
using System.Threading;
namespace CS_ADVANCE.Events
{
    /// <summary>
    /// https://www.youtube.com/watch?v=jQgwEsJISy0&index=3&list=PLTjRvDozrdlz3_FPXwb6lX_HoGXa09Yef
    /// </summary>
    public class VideoEncoder
    {
        //1- Define a delegate
        //2- Define an event based on that delegate
        //3- Raise the event

        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);        
        //public event VideoEncodedEventHandler VideoEncoded;
        
        public event EventHandler<VideoEventArgs> VideoEncoded; // Powyzsze dwie linie są tym samymy, co ta linia
        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }
        //Zgodnie z zaleceniami MSDN
        protected virtual void OnVideoEncoded() 
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs());
            }
        }
    }
}