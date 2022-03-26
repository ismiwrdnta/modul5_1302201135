using System;
using System.Collections;
using System.Collections.Generic;

namespace modul5_1302201135
{
	public class SayaTubeUser
	{
		private int id;
		List<SayaTubeVideo> uploadedVideo;
		public string Username;
		public SayaTubeUser(){}
		public SayaTubeUser(string username) { 
			this.Username = username;
			var rand = new Random();
			this.id = rand.Next(10000, 99999);
			this.uploadedVideo = new List<SayaTubeVideo>();
		}
		public int GetTotalVideoPlayCount()
        {
			int totalplay = 0;
			foreach (var video in this.uploadedVideo)
            {
				totalplay = totalplay + video.getPlayCount();
            }
			return totalplay;
        }

		public void AddVideo(SayaTubeVideo data)
        {
			uploadedVideo.Add(data);
        }

		public void PrintAllVideoPlaycount()
        {
			Console.WriteLine("Username : " + Username);
			int i = 0;
			foreach (SayaTubeVideo video in uploadedVideo)
            {
				Console.WriteLine("Video : "+ i+ " Judul video : " + video.getTitle());
				i++;
            }

        }
	}
}

