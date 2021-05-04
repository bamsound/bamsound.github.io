using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ITSYUIManager : MonoBehaviour
{

    public GameObject subMenu;

    public void Start()
    {
        subMenu.SetActive(false);
    }

    public void ToggleSubMenu()
    {
        subMenu.SetActive(!subMenu.activeInHierarchy);
    }
}