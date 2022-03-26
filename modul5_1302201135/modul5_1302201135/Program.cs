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
            SayaTubeVideo video2 = new SayaTubeVideo("Review film Jujutsu Kaisen 0 oleh Ismi");
            SayaTubeVideo video3 = new SayaTubeVideo("Review film The Hobbit oleh Ismi");
            SayaTubeVideo video4 = new SayaTubeVideo("Review film Lord Of The Rings oleh Ismi");
            SayaTubeVideo video5 = new SayaTubeVideo("Review film Hannah Montana The Movie oleh Ismi");
            SayaTubeVideo video6 = new SayaTubeVideo("Review film  Fantastic Beast oleh Ismi");
            SayaTubeVideo video7 = new SayaTubeVideo("Review film High School Musical oleh Ismi");
            SayaTubeVideo video8 = new SayaTubeVideo("Review film The Avengers Endgame oleh Ismi");
            SayaTubeVideo video9 = new SayaTubeVideo("Review film Now You See Me oleh Ismi");
            SayaTubeVideo video10 = new SayaTubeVideo("Review film Now You See Me 2 oleh Ismi");
            
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

            user.PrintAllVideoPlaycount();

        }
    }
}

