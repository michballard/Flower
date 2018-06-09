using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentExample : MonoBehaviour {

    public Item[] allItemList;
    //public List<Item> pickableItems;
    public PickUpComponent[] m_PickableItems;

    private void Awake()
    {
        allItemList = FindObjectsOfType<Item>();
        m_PickableItems = FindObjectsOfType<PickUpComponent>();

        /*
        foreach (Item item in allItemList)
        {
            if (item.isPickable)
                pickableItems.Add(item);
        }
        */
    }
}
