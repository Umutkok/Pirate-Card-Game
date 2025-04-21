using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddManaEffect : MonoBehaviour, ICardEffect
{
public int AddMana = 20;
ShipController ship;
GameManager gameManager;
void Start()
{
    ship = FindObjectOfType<ShipController>();
    gameManager = FindObjectOfType<GameManager>();
}
public void ApplyEffect()
{
    gameManager.currentMana += AddMana;
}

}
