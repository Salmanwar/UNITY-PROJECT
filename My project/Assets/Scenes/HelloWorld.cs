using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string gameName = "Super Mario Brothers";
    public int age = 30;

    /*private void OnDisable()
    {
        Debug.Log("The game " + gameName + " is " + age + " years old.");
    }*/
    private void Start()
    {
        Debug.Log("The game " + gameName + " is " + age + " years old.");
    }
    /*void OnEnable()
    {
        Debug.Log("Hello World!");
    }
    void OnDisable() { 
        Debug.Log("Bye Bye World!");
    }*/
}
