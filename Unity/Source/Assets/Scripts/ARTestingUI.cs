using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARTestingUI : MonoBehaviour
{
    
    // Setting variables to handle AR testing UI.
    public GameObject sessionOrigin;

    public GameObject[] episodes;
    public int currentEpisode = 0;
    
    private GameObject episodeContent;
    private GameObject[] episodeContents;

    private GameObject plane;
    private GameObject[] planes;
    
    // Resets the AR Session and destroy every "Episode" prefab on the scene.
    public void ResetExperience()
    {
        sessionOrigin.GetComponent<ARPlaneManager>().enabled = true;
        
        episodeContents = GameObject.FindGameObjectsWithTag("Episode");

        foreach (GameObject episodeContent in episodeContents)
        {
            Destroy(episodeContent);
        }
    }

    // Hide the AR planes and stop the AR Plane Manager from spawning more.
    // Current implementation is one-way. After hiding, user must reset the experience to reverse it.
    public void HideARUI()
    {
        sessionOrigin.GetComponent<ARPlaneManager>().enabled = false;
        
        planes = GameObject.FindGameObjectsWithTag("ARPlane");

        foreach (GameObject plane in planes)
        {
            plane.SetActive(false);
        }
    }

    // Resets the AR Session and destroy every "Episode" prefab on the scene.
    public void NextEpisode()
    {
        //var placeOnPlaneScript = sessionOrigin.GetComponent<PlaceOnPlane>();

        currentEpisode++;

        if(currentEpisode > (episodes.Length - 1))
        {
            currentEpisode = 0;
        }      

        //placeOnPlaneScript.m_ObjectToPlace = episodes[currentEpisode];
        Debug.Log(currentEpisode);

        ResetExperience();
    }
}