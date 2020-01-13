using System;

namespace Abstraction_2
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IRecodable, IPlayable
    {
        public void Record()
        {
            Console.WriteLine("Recording audio...");
        }

        public void Play()
        {
            Console.WriteLine("Playing audio...");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Playing paused");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Playing stoped");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Recording paused");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Recording stoped");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player pl = new Player();
            pl.Record();
            ((IRecodable)pl).Pause();
            ((IRecodable)pl).Stop();
            pl.Play();
            ((IPlayable)pl).Pause();
            ((IPlayable)pl).Stop();
            Console.ReadKey();
        }
    }
}
