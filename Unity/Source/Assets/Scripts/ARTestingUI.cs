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

    public GameObject episode;
    public GameObject[] episodes;

    public GameObject plane;
    public GameObject[] planes;
    
    // Resets the AR Session and destroy every "Episode" prefab on the scene.
    public void ResetExperience()
    {
        sessionOrigin.GetComponent<ARPlaneManager>().enabled = true;
        
        episodes = GameObject.FindGameObjectsWithTag("Episode");

        foreach (GameObject episode in episodes)
        {
            Destroy(episode);
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
}