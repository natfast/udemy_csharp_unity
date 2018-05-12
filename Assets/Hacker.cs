using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

	// Game State
	int level;
	enum Screen { MainMenu, Password, Win };
	Screen currentScreen = Screen.MainMenu;


	void Start()
	{
		string greeting = "Nat Fast";
		ShowMainMenu(greeting);

	}

	void OnUserInput(string input)
	{
		if (input == "menu")
		{
			currentScreen = Screen.MainMenu;
			ShowMainMenu("Welcome Back");
		}
		else if (currentScreen == Screen.MainMenu)
		{
			RunMainMenu(input);
		}
	}

	void RunMainMenu(string input)
	{
		if (input == "1" || input == "2" || input == "3")
		{
			// local library
			StartGame(input);
		}
		else if (input == "unknown")
		{
			ShowMainMenu("Your telling me!");
		}
		else
		{
			Terminal.WriteLine("   Unknown Value!");
			Terminal.WriteLine("Enter 1, 2 or 3:");
		}
	}

	void StartGame(string input)
	{
		currentScreen = Screen.Password;
		level = int.Parse(input);
		switch (level)
		{
			case 1:
				// Library

				Terminal.WriteLine("   Local Library");
				break;
			case 2:
				// Interpol
				Terminal.WriteLine("   Interpol");
				break;
			case 3:
				// NASA
				Terminal.WriteLine("   NASA");
				break;
		}
	}

	void ShowMainMenu(string gstring)
	{
		Terminal.ClearScreen();
		Terminal.WriteLine(gstring + ": Login successful!");
		Terminal.WriteLine("System Access Menu:");
		Terminal.WriteLine("");
		Terminal.WriteLine("1 - Local Library");
		Terminal.WriteLine("2 - Interpol");
		Terminal.WriteLine("3 - NASA");
		Terminal.WriteLine("");
		Terminal.WriteLine("Enter 1, 2 or 3:");
	}


}
