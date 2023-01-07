using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}  //using {get and set} to avalable only this class and other can't
    // public static GameManager Instance;

    public Text inputText;
    public string playerName;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void FixedUpdate() {
        playerName = inputText.text;
    }

    public void StartGame()
    {
        // do something...
        Debug.Log("Starting...");
    }

    public void Login(){

    }
}
