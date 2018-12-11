using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoUI : MonoBehaviour {
    public void LogLines(string message) 
    {
        Debug.Log("Hello World");
        Debug.Log("Foo Bar");
        Debug.LogWarning("Warned You");
        Debug.LogFormat("My custom message: {0}", message);
    }
}
