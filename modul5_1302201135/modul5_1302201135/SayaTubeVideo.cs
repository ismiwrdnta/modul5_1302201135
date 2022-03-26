using System;
using System.Diagnostics.Contracts;

namespace modul5_1302201135
{
	public class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;
		public SayaTubeVideo() { }
		public SayaTubeVideo(string title)
		{
			
			this.title = title;

			var rand = new Random();
			this.id = rand.Next(10000, 99999);

			this.playCount = 0;
		}

		public void setTitle(string a)
        {
			this.title = a;
        }
		public String getTitle()
        {
			return this.title;
        }
		
		public void setPlaycount(int a)
        {
			this.playCount = a;
        }

		public int getPlayCount()
        {
			return this.playCount;
        }
		public void IncreasePlayCount(int a)
		{
			
			try
			{	
				this.playCount = checked(this.playCount + a);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public void PrintVideoDetails()
		{
			Console.WriteLine("Video ID : " + this.id);
			Console.WriteLine("Video Title : " + this.title);
			Console.WriteLine("Video Playcount : " + this.playCount);
		}


	}
}