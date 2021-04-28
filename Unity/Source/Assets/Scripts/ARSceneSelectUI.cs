using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class ARSceneSelectUI : MonoBehaviour
{

public GameObject episode;

    // You can use it to make this GameObject not to destroy when scene unloads.
    void Awake() 
    {
        DontDestroyOnLoad(transform.gameObject);
        Debug.Log("My name is EpisodeManager and I will NEVER be destroyed!");
    }

    public void LoadITSYScene(GameObject chosenEpisode)
    {   
        episode = chosenEpisode;
        LoaderUtility.Initialize();
        SceneManager.LoadScene("ITSY", LoadSceneMode.Single);
        Debug.Log("Loading a scene with prefab " + episode + " loaded!");
    }

    void Update()
    {
        Debug.Log("My name is EpisodeManager and i'm alive!");
    }
}