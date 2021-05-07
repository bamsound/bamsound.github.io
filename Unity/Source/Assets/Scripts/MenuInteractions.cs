using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInteractions : MonoBehaviour
{



    public GameObject welcomeMenu;
    public GameObject chooseEpisodeMenu;

    private GameObject menuManager;
    private ARSceneSelectUI ARSelectScript;

    // Start is called before the first frame update
    public void Start()
    {
        
        menuManager = GameObject.Find("EpisodeManager");
        ARSelectScript = menuManager.GetComponent<ARSceneSelectUI>();
        
        if (ARSelectScript.shownMenu == true)
        {
            CloseWelcomeMenu();
        }
    }

    public void CloseWelcomeMenu()
    {
        welcomeMenu.gameObject.SetActive(false);
        chooseEpisodeMenu.gameObject.SetActive(true);
    }
}
