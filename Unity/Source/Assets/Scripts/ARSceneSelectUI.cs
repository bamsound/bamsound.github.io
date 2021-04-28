using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class ARSceneSelectUI : MonoBehaviour
{

public GameObject episode;

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
        episode = chosenEpisode;
        LoaderUtility.Initialize();
        SceneManager.LoadScene("ITSY", LoadSceneMode.Single);
    }
}