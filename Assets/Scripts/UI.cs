using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [Header("Scene Manager")]
    [SerializeField] private GameObject loadingMenu;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject gameMenu;

    public GameMode gameMode;
    public Text showName;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        OpenLoadingScene();

        // Invoke("OpenMainScene", 2f);
        // Invoke(nameof(OpenMainScene), 2f);
        StartCoroutine(ShowMenu());

        int player_id = GetPlayerID();
        Debug.Log(player_id);
    }

    // Update is called once per frame (depend-on --> CPU Speed)
    void Update()
    {
        
    }

    // All player are Update as the same time (fixed-time-to-update)
    private void FixedUpdate()
    {
        
    }

    private void LateUpdate()
    {
        
    }

    void OpenLoadingScene()
    {
        loadingMenu.GetComponent<Image>().color = Color.blue;
        loadingMenu.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(false);
        gameMenu.gameObject.SetActive(false);
    }

    void OpenMainScene()
    {
        loadingMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        gameMenu.gameObject.SetActive(false);
    }

    void OpenGameScene()
    {
        loadingMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
        gameMenu.gameObject.SetActive(true);
    }

    private int GetPlayerID()   // can be Type --> String, GameObject, etc...
    {
        return 1;
    }

    private IEnumerator ShowMenu()
    {
        if(gameMode == GameMode.SinglePlayer)
        {
            //do something here...
        }

        yield return new WaitForSeconds(2f);
        OpenMainScene();

        yield return new WaitForSeconds(2f);
    }

    public void Click_Start_Btn(){
        showName.text = "Welcome! " + GameManager.Instance.playerName;
        Invoke(nameof(OpenGameScene), 2f);
    }
}

// using for static
public enum GameMode
{
    SinglePlayer,
    MultiPlayer
}
