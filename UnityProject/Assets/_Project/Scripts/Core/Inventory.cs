using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public List <Item> m_Items;

    #region Method Region
    //Add an item to the inventory
    public bool TryAdd(Item item)
    {
        //We will find if item has component PickUpComponent
        if (!item.GetComponent<PickUpComponent>())
        {
            Debug.Log("This item is not Pickable");
            return false;
        }

        /* if (leftHand.TryAdd(item))
        {
            Debug.Log(item.name + " Added successfully");
        }
        else
            Debug.Log(item.name + " already exists");
        */

        if (!m_Items.Contains(item))
        {
            m_Items.Add(item);
            Debug.Log(item.name + " Added successfully");
            return true;
        }
        else
        {
            Debug.Log(item.name + " already exists");
            return false;
        }
        }

        //Remove an item from the inventory
        public void Remove(Item item)
    {
        if (m_Items.Contains(item))
            m_Items.Remove(item);
    }
    #endregion
}
