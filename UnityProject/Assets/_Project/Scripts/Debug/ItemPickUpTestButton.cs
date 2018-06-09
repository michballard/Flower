using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPickUpTestButton : MonoBehaviour, IPointerClickHandler, InterfaceExample {

    public Item m_TestItem;
    public PlayerCharacter playerCharacter;

    //Tell the playerCharacter to pick up m_TestItem
    public void OnPickUp()
    {
        playerCharacter.PickUp(m_TestItem);
    }

    //OnClick - When the user clicks the button
    public void OnPointerClick(PointerEventData eventData)
    {
        OnPickUp();
    }
    public void InterfaceMethod() { }
}

public interface InterfaceExample
{
    void InterfaceMethod();
}
