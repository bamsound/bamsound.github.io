using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class InterfaceEpisodeManager : MonoBehaviour
{
    
    public GameObject sessionOrigin;
    
    private GameObject menuManager;
    private ARSceneSelectUI ARSelectScript;
    private PlaceObjectsOnPlane placeOnPlaneScript;

    // Start is called before the first frame update
    void Start()
    {
        menuManager = GameObject.Find("EpisodeManager");

        ARSelectScript = menuManager.GetComponent<ARSceneSelectUI>();
        placeOnPlaneScript = sessionOrigin.GetComponent<PlaceObjectsOnPlane>();

        placeOnPlaneScript.placedPrefab = ARSelectScript.episode;
    }

    public void SendITSYScene(GameObject chosenPrefab)
    {   
        ARSelectScript.LoadITSYScene(chosenPrefab);
    }

    public void LoadMenu()
    {   
        LoaderUtility.Initialize();
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}