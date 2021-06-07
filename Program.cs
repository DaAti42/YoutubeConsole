using System;
using System.Collections.Generic;


namespace YoutubeConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            VideoDAO dao = new VideoDAO();
            Console.WriteLine("---------------");
            Console.WriteLine("menu");
            Console.WriteLine("1 Alle Anzeigen");
            Console.WriteLine("2 Suchen");
            Console.WriteLine("---------------");
            while (true)
            {
                int selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Alle Anzeigen");
                        List<Video> videos = dao.getAllVideos();

                        foreach (Video video in videos)
                        {
                            Console.WriteLine(video.title + " - " + video.description);
                        }

                        break;
                    case 2:
                        Console.WriteLine("Suchen");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
