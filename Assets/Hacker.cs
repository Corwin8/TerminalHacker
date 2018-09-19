using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	//game data
	string[] Level1Passwords = { "HAMMER", "VIRUS", "COCA COLA" };
	string[] Level2Passwords = { "VODKA", "RUSSIAN", "TERRORIST", "ASTEROID" };


	//game state
	int level;
	enum Screen { MainMenu, PasswordEasy, PasswordMedium, Win }
	string Password;
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
	void Update() {

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

		else if (CurrentScreen == Screen.PasswordEasy)
		{
			RunPasswordGuessEasy(input);
		}

		else if (CurrentScreen == Screen.PasswordMedium)
		{
			RunPasswordGuessMedium(input);
		}

		else if (CurrentScreen == Screen.Win)
		{
			ShowMainMenu();
		}

	}

	void RunMainMenu(string input)
	{
		bool IsValidLevel = (input == "1" || input == "2");

		if (IsValidLevel)
		{
			level = int.Parse(input);
			switch (level)
			{
				case 1:
					CurrentScreen = Screen.PasswordEasy;
					Password = Level1Passwords[Random.Range(0, Level1Passwords.Length)];
					break;
				case 2:
					CurrentScreen = Screen.PasswordMedium;
					Password = Level2Passwords[Random.Range(0, Level2Passwords.Length)];
					break;
				default:
					Terminal.WriteLine("You are talking nonsense, man!");
					Debug.Log("Invalid level selection.");
					break;
			}
		}
		else
		{
			Terminal.WriteLine("I told you to choose a level, you are not making any sense!");
		}
	}

	void RunPasswordGuessEasy(string input)
	{
		Terminal.ClearScreen();

		if (input == Password)
		{
			CurrentScreen = Screen.Win;
			GiveReward();
		}

		else
		{
			Terminal.WriteLine("WRONG! Try again: ");
		}
	}

	void GiveReward()
	{
		Terminal.ClearScreen();
		switch (level)
		{
			case 1:
				{
					Terminal.WriteLine("Are you happy now?");
					Terminal.WriteLine(@"


      _______________
      |              |
      |   HAL9000    |
      |              |
      |Will I dream? |
      |______________|
					");
				}
				break;
			case 2:
				{
					Terminal.WriteLine("Are you happy now?");
					Terminal.WriteLine(@"

            /\
           /  \
          /    \
         /      \
		/ (    ) \
       /    __    \
      /____________\
					");
				}
				break;
			default:
				{
					Terminal.WriteLine("There is no such thing, fool!");
					break;
				}
		}
	}
	void RunPasswordGuessMedium(string input)
	{
		Terminal.ClearScreen();
		if (input == Password)
			{
				CurrentScreen = Screen.Win;
				GiveReward();
			}

		else
		{
			Terminal.WriteLine("WRONG! Try again: ");
		}
	}
}