using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AddWeaponEffect : MonoBehaviour, ICardEffect
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
    if (ship == null)
    {
        Debug.Log("shipIsNull");
    }
    
    switch(gameManager.shipCannonNumber)
    {
        case 1:
            ship.transform.GetChild(2).gameObject.SetActive(true);
            gameManager.shipCannonNumber++;
            break;

        case 2:
            ship.transform.GetChild(3).gameObject.SetActive(true);
            gameManager.shipCannonNumber++;
            break;
        case 3:
            ship.transform.GetChild(4).gameObject.SetActive(true);
            gameManager.shipCannonNumber++;
            break;
    }

}


}
