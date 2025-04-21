using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Deck : MonoBehaviour
{
private Dictionary<GameObject, int> cardDictionary = new Dictionary<GameObject, int>();
public List<GameObject> CardsInDeck;
public CardManagerSO CardManagerSO;
public GameObject Slot;

void Start()
{
   //Kart türlerini ve sayıları dictionary ye ekle
   cardDictionary.Add(CardManagerSO.AddWeapon, CardManagerSO.AddWeaponCount);
   cardDictionary.Add(CardManagerSO.NormalFire, CardManagerSO.NormalFireCount);
   cardDictionary.Add(CardManagerSO.Mana, CardManagerSO.ManaCount);
   cardDictionary.Add(CardManagerSO.PiercingDamage, CardManagerSO.PiercingDamageCount);
   cardDictionary.Add(CardManagerSO.Bomb, CardManagerSO.BombCount);
   cardDictionary.Add(CardManagerSO.Shield, CardManagerSO.ShieldCount);
   cardDictionary.Add(CardManagerSO.Freeze, CardManagerSO.FreezeCount);
   cardDictionary.Add(CardManagerSO.Cleaner, CardManagerSO.CleanerCount);
   cardDictionary.Add(CardManagerSO.UltimateDamage, CardManagerSO.UltimateDamageCount);
   cardDictionary.Add(CardManagerSO.ManaDamage, CardManagerSO.ManaDamageCount);
   cardDictionary.Add(CardManagerSO.TakeTwo, CardManagerSO.TakeTwoCount);
   cardDictionary.Add(CardManagerSO.Heal, CardManagerSO.HealCount);
   cardDictionary.Add(CardManagerSO.ManaBoost, CardManagerSO.ManaBoostCount);

   ResetDeck();
   PopulateDeck();

}
public void DrawCard()
{
   if(Slot.transform.childCount<10)
   {
      int randomIndex = Random.Range(0, CardsInDeck.Count);
      GameObject DrawedCard = CardsInDeck[randomIndex];
      Instantiate(DrawedCard,Slot.transform);
      CardsInDeck.RemoveAt(randomIndex);
   }
}  

private void ResetDeck()
{
   CardsInDeck.Clear();
}

private void PopulateDeck()
{
   foreach (var card in cardDictionary)
   {
      for (int i = 0; i < card.Value; i++)
      {
         CardsInDeck.Add(card.Key);
      }
   }   
}
}
