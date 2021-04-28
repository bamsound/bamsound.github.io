using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCurrentEpisode : MonoBehaviour
{
    
    public GameObject sessionOrigin;
    
    private GameObject menuManager;

    // Start is called before the first frame update
    void Start()
    {
        menuManager = GameObject.Find("EpisodeManager");
        Debug.Log("I am a script and I've found an EpisodeManager survivor!");

        var ARSelectScript = menuManager.GetComponent<ARSceneSelectUI>();
        var placeOnPlaneScript = sessionOrigin.GetComponent<PlaceObjectsOnPlane>();
        
        Debug.Log("I see that MenuManager is telling me to choose this prefab: " + ARSelectScript.episode);

        placeOnPlaneScript.placedPrefab = ARSelectScript.episode;
        Debug.Log("And the final prefab is... " + placeOnPlaneScript.placedPrefab + "!");
    }
}