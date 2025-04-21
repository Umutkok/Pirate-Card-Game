using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardDropArea : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
[HideInInspector] public GameManager gameManager;
public Transform Slot; //TakeTwo kartı için gereken referans 

public void OnPointerEnter(PointerEventData eventData)
{

}
public void OnPointerExit(PointerEventData eventData)
{

}
public void OnDrop(PointerEventData eventData)
{
    Debug.Log(eventData.pointerDrag.name + "dropped" + gameObject.name);
    Card ondrag = eventData.pointerDrag.GetComponent<Card>();
    ICardEffect cardEffect = eventData.pointerDrag.GetComponent<ICardEffect>();
    if(ondrag != null)
    {
        ondrag.parentToReturnTo = this.transform;
        gameManager.currentMana -= ondrag.manaCostInt;

        cardEffect.ApplyEffect();
    } 
}



}
