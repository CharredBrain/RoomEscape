using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayImage : MonoBehaviour
{
    public int CurrentWall 
    {
        get { return currentwall;}
        set 
        {
            if (value==5) {currentwall = 1;}
            else if (value ==0) {currentwall = 4;}
            else {currentwall = value;}
        }
    }

    private int currentwall;
    private int previouswall;

    // Start is called before the first frame update
    void Start()
    {
        previouswall = 0;
        currentwall = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentwall != previouswall)
        {
            this.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/allwall" + currentwall.ToString());
        }
        previouswall=currentwall;
    }
}
