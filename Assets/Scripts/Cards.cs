using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType { Damage, Defense, AddWeapon, Mana, PiercingDamage, ManaDamage, TakeTwo, Cleaner, UltimateDamage, Shield, Freeze, Bomb, Heal, ManaBoost, CardPick}
public enum TargetType { Self, Enemy, AllShips }

[CreateAssetMenu(fileName = "NewCard", menuName = "Card System/Card")]
public class Cards : ScriptableObject
{
    public string cardName;
    public string getCardName => cardName;
    public Sprite cardImage;
    public Sprite cardImage1;
    public Sprite cardImage2;
    public Sprite cardImage3;
    public CardType cardType;
    public int manaCost;
    public TargetType targetType;

    // Etkiler için genel bir interface
    public ICardEffect effect;

}
