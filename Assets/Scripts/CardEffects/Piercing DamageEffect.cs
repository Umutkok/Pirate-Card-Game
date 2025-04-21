using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiercingDamageEffect : MonoBehaviour, ICardEffect
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
StartCoroutine(EffectActive());
IEnumerator EffectActive()
{
    for(int i = 0; i<10; i++)
    {
        yield return new WaitForSeconds(1);
        gameManager.shiphealt -= 1;
    }
}
}

}
