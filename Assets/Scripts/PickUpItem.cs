using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour, IInteractable
{
    public string DisplaySprite;
    public string DisplayImage;
    private GameObject InventorySlots;
    public enum property {usable, displayable};
    public property itemProperty; 

    public void Interact(DisplayImage currentDisplay)
    {
        ItemPickUp();
    }

    void Start()
    {
        
    }

    void ItemPickUp()
    {
        
        foreach(Transform slot in InventorySlots.transform)
        {
            if (slot.transform.GetChild(0).GetComponent<Image>().sprite.name == "nothing")
            {
                slot.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Collectables/" + DisplaySprite);
                slot.GetChild(0).GetComponent<Slot>().AssignProperty((int)itemProperty, DisplayImage);
                Destroy(gameObject);
                break;
            }
        }
    }
}
