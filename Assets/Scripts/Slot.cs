using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    private GameObject inventory;
    private string displayImage;
    public enum property {usable, displayable, empty};
    public property ItemProperty {get; set;}


    void Start()
    {
        inventory = GameObject.Find("Inventory");
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        inventory.GetComponent<Inventory>().previousSelectedSlot = inventory.GetComponent<Inventory>().currentSelectedSlot;
        inventory.GetComponent<Inventory>().currentSelectedSlot = this.gameObject;
        if (ItemProperty == Slot.property.displayable) 
        {
            DisplayItem();
        }
    }

    public void AssignProperty(int orderNumber, string displayImage)
    {
        ItemProperty = (property)orderNumber;
        this.displayImage = displayImage;
    }

    public void DisplayItem()
    {
        inventory.GetComponent<Inventory>().itemDisplayer.SetActive(true);
        inventory.GetComponent<Inventory>().itemDisplayer.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Collectables/" + displayImage);
    }

    public void ClearSlot()
    {
        ItemProperty = Slot.property.empty;
        displayImage = "";
        transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/nothing");
    }
}
