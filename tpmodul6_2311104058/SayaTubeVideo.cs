using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_2311104058
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title) || title.Length > 100)
                throw new ArgumentException("Title cannot be null, empty, or exceed 100 characters");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 10000000)
                throw new ArgumentException("Play count increment must be between 0 and 10,000,000");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count overflow detected!");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video Details:");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }


}
