using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealEffect : MonoBehaviour, ICardEffect
{
    GameManager gameManager;
void Start()
{
    gameManager = FindObjectOfType<GameManager>();
}

public void ApplyEffect()
{
StartCoroutine(EffectActive());
IEnumerator EffectActive()
{
    for(int i = 0; i<15; i++)
    {
        yield return new WaitForSeconds(1);
        gameManager.Redshiphealt += 1;
    }
}
}
}
