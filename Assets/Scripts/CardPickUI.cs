using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardPickUI : MonoBehaviour
{
    /*
    public Transform Slot;
    public Cards Cards;
    public CardManagerSO CardManagerSO;
    private Dictionary<GameObject, int> cardDictionary = new Dictionary<GameObject, int>();
    public List<GameObject> CardsInDeck;
    [SerializeField] private TMP_Text cardName;
    [SerializeField] private Image cardImage;
    [SerializeField] private CardType cardType;
    [SerializeField] private TMP_Text manaCost;
    [SerializeField] private TargetType targetType;
   
    void Start()
    {
        cardName.text = Cards.cardName;
        cardImage.sprite = Cards.cardImage;
        cardType = Cards.cardType;
        manaCost.text = Cards.manaCost.ToString();
        targetType = Cards.targetType;

        cardDictionary.Add(CardManagerSO.AddWeapon,1);
        cardDictionary.Add(CardManagerSO.NormalFire, 1);
        cardDictionary.Add(CardManagerSO.Mana, 1);
        cardDictionary.Add(CardManagerSO.PiercingDamage, 1);
        cardDictionary.Add(CardManagerSO.Bomb, 1);
        cardDictionary.Add(CardManagerSO.Shield, 1);
        cardDictionary.Add(CardManagerSO.Freeze, 1);
        cardDictionary.Add(CardManagerSO.Cleaner, 1);
        cardDictionary.Add(CardManagerSO.UltimateDamage, 1);
        cardDictionary.Add(CardManagerSO.ManaDamage, 1);
        cardDictionary.Add(CardManagerSO.TakeTwo, 1);
        cardDictionary.Add(CardManagerSO.Heal, 1);


    }

    // Update is called once per frame
    void Update()
    {
        cardpick();
        PopulateDeck();
        switch(Cards.cardType)
        {
         case CardType.Damage:
            cardDictionary.Value(0) = cardType;
            break;
         case CardType.AddWeapon:
            gameObject.AddComponent<AddWeaponEffect>();
            Debug.Log("WeaponScript added: ");
            break;
         case CardType.ManaBoost:
            gameObject.AddComponent<AddManaEffect>();
            break;
        case CardType.PiercingDamage:
            gameObject.AddComponent<PiercingDamageEffect>();
            break;
        case CardType.ManaDamage:
            gameObject.AddComponent<ManaDamageEffect>();
            break;
        case CardType.TakeTwo:
            gameObject.AddComponent<TakeTwoEffect>();
            break;
        case CardType.Cleaner:
            gameObject.AddComponent<CleanerEffect>();
            break;
        case CardType.UltimateDamage:
            gameObject.AddComponent<UltimateDamageEffect>();
            break;
        case CardType.Shield:
            gameObject.AddComponent<ShieldEffect>();
            break;
        case CardType.Freeze:
            gameObject.AddComponent<FreezeEffect>();
            break;
        case CardType.Bomb:
            gameObject.AddComponent<BombEffect>();
            break;
        case CardType.Heal:
            gameObject.AddComponent<HealEffect>();
            break;
        case CardType.CardPick:
            gameObject.AddComponent<CardPickEffect>();
            break;
    }

    void cardpick()
    {
        GameObject DrawedCard = CardsInDeck[];
    }

    private void PopulateDeck()
{
   foreach (var cardUI in cardDictionary)
   {
      for (int i = 0; i < cardUI.Value; i++)
      {
         CardsInDeck.Add(cardUI.Key);
      }
   }   
   
}
*/
}
