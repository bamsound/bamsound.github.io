using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInteractions : MonoBehaviour
{

    public GameObject welcomeMenu;
    public GameObject chooseEpisodeMenu;

    // Start is called before the first frame update
    public void CloseWelcomeMenu()
    {
        welcomeMenu.gameObject.SetActive(false);
        chooseEpisodeMenu.gameObject.SetActive(true);
    }
}
