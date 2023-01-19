using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDisplayer : MonoBehaviour
{
    public GameObject DisplayObject;

    public void Interract(DisplayImage currentDisplay)
    {
        DisplayObject.SetActive(true);
    }
}
