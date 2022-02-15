using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadUserInput : MonoBehaviour
{
    public string userInput;
    
    public void ReadInput(string input)
    {
        userInput = input;
        Debug.Log(userInput);
    }
}
