using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	int level;

	//string greeting = "Hello JD";

	// Use this for initialization
	void Start() {
		ShowMainMenu();
	}

	void ShowMainMenu()
	{
		Terminal.ClearScreen();
		Terminal.WriteLine("Hello JD");
		Terminal.WriteLine("What do you want to destroy first?");
		Terminal.WriteLine("#1 PC");
		Terminal.WriteLine("#2 Nuclear powerplant");
		Terminal.WriteLine("#3 My mind");
		Terminal.WriteLine("Enter the number of your choice:");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnUserInput(string input)
	{
		if (input == "Menu")
		{
			ShowMainMenu();
		}

		else if (input == "1")
		{
			level = 1;
			StartGame(1);
		}

		else if (input == "2")
		{
			level = 2;
			StartGame(2);
		}

		else
		{
			Terminal.WriteLine("You are talking nonsense, man!");
		}

	}

	void StartGame(int level)
	{
		Terminal.WriteLine("You have chosen level " + level);
	}

}
