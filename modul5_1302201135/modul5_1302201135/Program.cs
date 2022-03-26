using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace modul5_1302201135
{
    public class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("Ismi");
            SayaTubeVideo video1 = new SayaTubeVideo("Review film Harry Potter oleh Ismi");
            video1.IncreasePlayCount(12345);
            SayaTubeVideo video2 = new SayaTubeVideo("Review film Jujutsu Kaisen 0 oleh Ismi");
            video2.IncreasePlayCount(12345);
            SayaTubeVideo video3 = new SayaTubeVideo("Review film The Hobbit oleh Ismi");
            video3.IncreasePlayCount(12345);
            SayaTubeVideo video4 = new SayaTubeVideo("Review film Lord Of The Rings oleh Ismi");
            video4.IncreasePlayCount(12345);
            SayaTubeVideo video5 = new SayaTubeVideo("Review film Hannah Montana The Movie oleh Ismi");
            video5.IncreasePlayCount(12345);
            SayaTubeVideo video6 = new SayaTubeVideo("Review film  Fantastic Beast oleh Ismi");
            video6.IncreasePlayCount(12345);
            SayaTubeVideo video7 = new SayaTubeVideo("Review film High School Musical oleh Ismi");
            video7.IncreasePlayCount(12345);
            SayaTubeVideo video8 = new SayaTubeVideo("Review film The Avengers Endgame oleh Ismi");
            video8.IncreasePlayCount(12345);
            SayaTubeVideo video9 = new SayaTubeVideo("Review film Now You See Me oleh Ismi");
            video9.IncreasePlayCount(12345);
            SayaTubeVideo video10 = new SayaTubeVideo("Review film Now You See Me 2 oleh Ismi");
            video10.IncreasePlayCount(12345);
            SayaTubeVideo video11 = new SayaTubeVideo(null);

            user.AddVideo(video1);
            user.AddVideo(video2);
            user.AddVideo(video3);
            user.AddVideo(video4);
            user.AddVideo(video5);
            user.AddVideo(video6);
            user.AddVideo(video7);
            user.AddVideo(video8);
            user.AddVideo(video9);
            user.AddVideo(video10);
            user.AddVideo(video11);

            video1.PrintVideoDetails();
            video2.PrintVideoDetails();
            video3.PrintVideoDetails();
            user.PrintAllVideoPlaycount();

            Console.WriteLine("Total play count : " + user.GetTotalVideoPlayCount());

        }
    }
}

