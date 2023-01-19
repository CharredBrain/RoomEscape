using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsManager : MonoBehaviour
{
    private DisplayImage currentDisplay;
    public GameObject[] ObjectsToManage;

    void Start()
    {
        currentDisplay = GameObject.Find("Image").GetComponent<DisplayImage>();
    }

    void Update()
    {
        ManageObjects();
    }
    
    void ManageObjects()
    {
        for (int i = 0; i<ObjectsToManage.Length; i++)
        {
            if (ObjectsToManage[i].name == currentDisplay.GetComponent<Image>().sprite.name)
            {
                ObjectsToManage[i].SetActive(true);
            }
            else
            {
                ObjectsToManage[i].SetActive(false);
            }
        }

    }
}
