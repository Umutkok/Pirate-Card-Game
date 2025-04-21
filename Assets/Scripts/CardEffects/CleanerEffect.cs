using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanerEffect : MonoBehaviour, ICardEffect
{
    //TakeTwo dan sonra yazdım benzer bir kod olduğu için dikkat et
    public CardDropArea DropArea;
    public Transform Slot;

    void Awake()
    {
        DropArea = FindObjectOfType<CardDropArea>();
        Slot = DropArea.Slot;
    }

    public void ApplyEffect()
    {
        int randomIndex = Random.Range(0, Slot.transform.childCount);
        Slot.transform.GetChild(randomIndex).SetParent(DropArea.transform);

        int randomIndex2 = Random.Range(0, Slot.transform.childCount);
        Slot.transform.GetChild(randomIndex2).SetParent(DropArea.transform);

        int randomIndex3 = Random.Range(0, Slot.transform.childCount);
        Slot.transform.GetChild(randomIndex3).SetParent(DropArea.transform);
    }

}
