using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private void Awake() {
        Open_Game();
    }

    void Open_Game()
    {
        GameManager.Instance.StartGame();        
    }

    
}
