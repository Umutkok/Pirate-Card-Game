using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class TakeTwoEffect : MonoBehaviour, ICardEffect
{
    public CardDropArea DropArea;
    public Transform Slot;

    void Awake()
    {
        DropArea = FindObjectOfType<CardDropArea>();
        Slot = DropArea.Slot;
    }

    public void ApplyEffect()
    {
        int randomIndex = Random.Range(0, DropArea.transform.childCount);
        DropArea.transform.GetChild(randomIndex).SetParent(Slot);

        int randomIndex2 = Random.Range(0, DropArea.transform.childCount);
        DropArea.transform.GetChild(randomIndex2).SetParent(Slot);
    }

}
