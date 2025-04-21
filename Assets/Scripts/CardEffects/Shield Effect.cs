using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldEffect : MonoBehaviour, ICardEffect
{
    public GameManager gameManager;
    void Start()
{
    gameManager = FindObjectOfType<GameManager>();
}
    public void ApplyEffect()
    {
        gameManager.shield.gameObject.SetActive(true);

    }
}
