using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadUserInput : MonoBehaviour
{
    public GameDataManager gameDataManager;
    
    public string userInput;
    
    public void ReadInput(string input)
    {
        userInput = input;
        gameDataManager.currentUser = userInput;
        Debug.Log(userInput);
    }
}
