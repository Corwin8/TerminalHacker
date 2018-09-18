using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	//game state
	int level;
	enum Screen { MainMenu, Password, Win }
	Screen CurrentScreen;

	// Use this for initialization
	void Start() {
		ShowMainMenu();
	}

	void ShowMainMenu()
	{
		CurrentScreen = Screen.MainMenu;
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

		else if (CurrentScreen == Screen.MainMenu)
		{
			RunMainMenu(input);
		}

	}

	void RunMainMenu(string input)
	{
		if (input == "1")
		{
			level = 1;
			StartGame();
		}

		else if (input == "2")
		{
			level = 2;
			StartGame();
		}

		else
		{
			Terminal.WriteLine("You are talking nonsense, man!");
		}
	}

	void StartGame()
	{
		Terminal.WriteLine("You have chosen level " + level);
		Terminal.WriteLine("Please, enter your password: ");
		CurrentScreen = Screen.Password;
	}
}
