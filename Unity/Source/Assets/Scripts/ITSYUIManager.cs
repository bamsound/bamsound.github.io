using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ITSYUIManager : MonoBehaviour
{

    public GameObject menuButton;
    public GameObject subMenu;
    public GameObject subMenuOverlay;
    public GameObject instructions;

    private GameObject menuManager;
    private ARSceneSelectUI ARSelectScript;

    public void Start()
    {
        subMenu.SetActive(false);
        menuButton.SetActive(true);
        menuManager = GameObject.Find("EpisodeManager");
        ARSelectScript = menuManager.GetComponent<ARSceneSelectUI>();

        if (ARSelectScript.shownEpisode == false)
        {
            ShowInstructions();
        }
        else
        {
            menuButton.SetActive(true);
        }
    }

    public void ToggleSubMenu()
    {
        subMenu.SetActive(!subMenu.activeInHierarchy);
        subMenuOverlay.SetActive(!subMenuOverlay.activeInHierarchy);
    }

    public void ShowInstructions()
    {
        menuButton.SetActive(false);
        subMenuOverlay.SetActive(true);
        instructions.SetActive(true);
    }

    public void HideInstructions()
    {
        menuButton.SetActive(true);
        subMenuOverlay.SetActive(false);
        instructions.SetActive(false);
        ARSelectScript.shownEpisode = true;
    }

    public void LearnMore()
    {
        subMenu.SetActive(!subMenu.activeInHierarchy);
        subMenuOverlay.SetActive(!subMenuOverlay.activeInHierarchy);
        Application.OpenURL("https://www.bekindmovement.co.uk/");
    }
}