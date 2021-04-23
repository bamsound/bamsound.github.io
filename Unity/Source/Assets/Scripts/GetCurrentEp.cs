using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCurrentEp : MonoBehaviour
{

    // Setting variables to handle AR testing UI.
    public GameObject sessionOrigin;
    
    private ARTestingUI ARTestingUIScript;

    // Start is called before the first frame update
    void Start()
    {
        ARTestingUIScript = sessionOrigin.GetComponent<ARTestingUI>();
    }

    // Update is called once per frame
    void Update()
    {        
        var episodeToShow = ARTestingUIScript.currentEpisode + 1;
        gameObject.GetComponent<Text>().text = "Ep: " + episodeToShow;
    }
}
