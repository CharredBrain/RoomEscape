using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private DisplayImage currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("Image").GetComponent<DisplayImage>();
    }

    public void ForLeftClick()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 1;
    }

    public void ForRightClick()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall - 1;
    }
}
