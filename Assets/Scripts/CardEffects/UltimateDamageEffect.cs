using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateDamageEffect : MonoBehaviour, ICardEffect
{
public int Damage = 10;
ShipController ship;
GameManager gameManager;
void Start()
{
    ship = FindObjectOfType<ShipController>();
    gameManager = FindObjectOfType<GameManager>();
}
public void ApplyEffect()
{
    gameManager.shiphealt -= Damage*gameManager.shipCannonNumber;
    ship.cannonanim.SetBool("cannonanimtrigger", true);

    switch(gameManager.shipCannonNumber)
    {
        case 1:
            ship.spawnbullet1();
            break;
        case 2:
            ship.spawnbullet2();
            break;
        case 3:
            ship.spawnbullet3();
            break;
        case 4:
            ship.spawnbullet4();
            break;
    }

}


}
