using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class ARSceneSelectUI : MonoBehaviour
{

public GameObject episode;
private GameObject session;

private static GameObject instance;

    // You can use it to make this GameObject not to destroy when scene unloads.
    void Awake() 
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadITSYScene(GameObject chosenEpisode)
    {   
        session = GameObject.Find("AR Session");
        
        if (session != null)
        {
            var sessionScript = session.GetComponent<ARSession>();
            sessionScript.Reset();
        }

        if (chosenEpisode != null)
        {
            episode = chosenEpisode;
        }

        LoaderUtility.Initialize();
        SceneManager.LoadScene("ITSY", LoadSceneMode.Single);
    }
}