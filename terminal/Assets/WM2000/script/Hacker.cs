using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    string testpass;
    string currentscreen = "mainmenu"; //to save screen

    // Start is called before the first frame update
    void Start()
    {
        Showmainmenu("hewwo");
        
    }

    void Showmainmenu(string greeting)
    {
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("press 1 to get inside area 51");
        Terminal.WriteLine("press 2 to get inside YOUR MIND");
    }
    
    void OnUserInput(string input)
    {
        if (currentscreen == "mainmenu")
        {
            Setlevel(input);
        }
        else if (currentscreen == "passwordscreen")
        {
            Checkpassword(input);
        }
    }


    void Setlevel(string selectedlevel)
    {
        if (selectedlevel == "1")
        {
            level = 1;
            Setrandompassword();
        }

        else if (selectedlevel == "2")
        {
            level = 2;
            Setrandompassword();
        }
        
        else
        {
            Terminal.WriteLine("calling the police!");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("level: " + level);
        currentscreen = "passwordscreen";
    }

    void Setrandompassword()
    {
        StartGame();

        switch (level)
        {
            case 1:
                testpass = "safe";
                Terminal.WriteLine(testpass);
                break;
            case 2:
                testpass = "safe";
                Terminal.WriteLine(testpass);
                break;
            default:
                break;
        }
    }

    void Checkpassword(string userinput)
    {
        if (userinput == testpass)
            Terminal.WriteLine("correct! OwO");

    }
}
