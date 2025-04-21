using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaDamageEffect : MonoBehaviour, ICardEffect
{
ShipController ship;
GameManager gameManager;


void Start()
{
    ship = FindObjectOfType<ShipController>();
    gameManager = FindObjectOfType<GameManager>();
}

public void ApplyEffect()
{
    gameManager.shiphealt -= gameManager.currentMana/2;
}

}

