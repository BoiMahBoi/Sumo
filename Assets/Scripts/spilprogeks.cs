using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spilprogeks : MonoBehaviour
{
    int myNumber = 5;
    string myText = "How are you?";

    // Start is called before the first frame update
    void Start()
    {
        string[] potions = { "inferno", "invisibility", "rage", "obsidian skin", "hunter", "night owl" };

        Debug.Log(potions[0]);
        
        potions[0] = "battle";
        
        Debug.Log(potions[0]);


        for(int i = 0; i < potions.Length; i++) 
        {
            Debug.Log(potions[i]);
        }

        Debug.Log(potions.Length);


        bool myBool = true;

        do
        {
            Debug.Log("Boolean is true");
        }
        while (myBool == false);

        foreach (string i in potions)
        {
            Debug.Log(i);
        }

        if (myNumber > 1 && myText != "I´m good" || myBool == true)
        {
            Debug.Log("the if statement is true");
        }
        else
        {
            Debug.Log("the if statement is false");
        }
    }

}
