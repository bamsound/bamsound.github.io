using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceOnPlane : MonoBehaviour
{
    
    // AR setup required to detect planes
    [SerializeField]
    ARRaycastManager m_RaycastManager;

    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

    [SerializeField]
    GameObject m_ObjectToPlace;

    // Setting variables to handle AR 3D elements
    public float yOffset;
    public GameObject episode;
    public GameObject[] episodes;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            
            // Restricts only one "Episode" prefab at the time.
            episodes = GameObject.FindGameObjectsWithTag("Episode");

            if (episodes.Length <= 0)
            {

                // Upon successfull touch register, instantiate an episode on the scene, with a y offset.
                Touch touch = Input.GetTouch(0);

                if(touch.phase == TouchPhase.Began)
                {
                    if(m_RaycastManager.Raycast(touch.position, s_Hits, TrackableType.PlaneWithinPolygon))
                    {
                        Pose hitPose = s_Hits[0].pose;

                        var offsetHitPose = new Quaternion(hitPose.rotation.x, hitPose.rotation.y + yOffset, hitPose.rotation.z, hitPose.rotation.w);

                        Instantiate(m_ObjectToPlace, hitPose.position, offsetHitPose);
                    }
                }                
            }
        }
    }
}