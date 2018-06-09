using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : Inventory {
    public Tool m_CurrentTool;

    public Handedness handedness;

    #region Logic

    private void OnTriggerEnter(Collider collider)
    {
        //Try to find item from collider using GetComponent.
        Item item = collider.GetComponent<Item>();

        //If the collider does not hav an item component
        //item will be null
        //Otherwise item is not = null because we found the item component

        //IF the item does not exist, we do nothing
        if (item == null) return;

        //Checking m_CurrentTool to see if it matches any of the results/cases below
        switch (m_CurrentTool)
        {
            //Define the cases here!
            
            //The case that the tool is none
            case Tool.none:
                TryAdd(item);
                break;

            case Tool.cut:
                TryCut(item);
                break;

        }
    }
    #endregion

    #region Methods
    public bool TryCut(Item item)
    {
        if(item.GetComponent<CutComponent>())
        {
            Debug.Log("Cut " + item.name);
            return true;
        } else
        {
            Debug.Log(item.name + " can not be cut");
            return false;
        }
        
    }
    #endregion
}

public enum Tool
{
    none, //By default, you can pick up and place items down
    cut //Allows you to cut also known as Trim
}

public enum Handedness
{
    left,
    right
}
