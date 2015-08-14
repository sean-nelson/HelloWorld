using System;

namespace HelloWorld
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Message myMessage = new Message ("Hello World");
			myMessage.Print ();

			Message[] messages = new Message[4];
			messages[0] = new Message ("Welcome back oh great creator");
			messages[1] = new Message ("What a lovely name");
			messages[2] = new Message ("Great name");
			messages[3] = new Message ("Thats a silly name, you suck!");

			Console.WriteLine ("Enter your name: ");
			String name = Console.ReadLine ();

			if (name.ToLower () == "sean") {
				messages [0].Print ();
			} else if (name.ToLower () == "willem") {
				messages [1].Print ();
			} else if (name.ToLower () == "jason") {
				messages [2].Print ();
			} else {
				messages [3].Print ();
			}

			Console.ReadLine ();
		}
	}
}
