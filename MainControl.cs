using System.IO;
using UnityEngine;
using System;
using System.Collections;

public class codenstuff
{
	public static void main ()
	{
		Console.WriteLine ("Initializing");
		StreamReader Characters = new StreamReader(new FileStream ("Characters.dat", FileMode.Open, FileAccess.ReadWrite));
		string[] characters = new string[2000];
		for (int i = 0; i < 36; i++) {
			characters[i] = Characters.ReadLine ();
		}
		Console.WriteLine ("Got list of characters");
		StreamReader Hints = new StreamReader(new FileStream ("Hints.dat", FileMode.Open, FileAccess.ReadWrite));
		string[] hints = new string[2000];
		for (int i = 0; i < 2000; i++) {
			hints[i] = Hints.ReadLine ();
		}
	}
}
