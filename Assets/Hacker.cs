using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	//game state
	int level;
	enum Screen { MainMenu, PasswordEasy, PasswordMedium, Win }
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
		if (input == "1")
		{
			level = 1;
			CurrentScreen = Screen.PasswordEasy;
			Terminal.WriteLine("Guess password that consists of these letters: M, R, A, E, M, H");
			Terminal.WriteLine("Type your guess: ");
		}

		else if (input == "2")
		{
			level = 2;
			CurrentScreen = Screen.PasswordMedium;
			Terminal.WriteLine("Guess password that consists of these letters: D, O, V, K, A");
			Terminal.WriteLine("Type your guess: ");
		}

		else
		{
			Terminal.WriteLine("You are talking nonsense, man!");
		}
	}

	void RunPasswordGuessEasy(string input)
	{

		if (input == "HAMMER")
		{
			CurrentScreen = Screen.Win;
			Terminal.WriteLine("Congratulations, you managed to destroy your PC.");
		}

		else
		{
			Terminal.WriteLine("WRONG! Try again: ");
		}
	}

	void RunPasswordGuessMedium(string input)
	{
		Terminal.ClearScreen();

		if (input == "VODKA")
		{
			CurrentScreen = Screen.Win;
			Terminal.WriteLine("Congratulations, you managed to destroy the Nuclear Powerplant.");
		}

		else
		{
			Terminal.WriteLine("WRONG! Try again: ");
		}
	}
}