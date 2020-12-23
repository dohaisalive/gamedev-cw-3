using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
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
    
}
