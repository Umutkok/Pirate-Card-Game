using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card System/CardManager")]
public class CardManagerSO : ScriptableObject
{
[Header("AddWeapon")]
public GameObject AddWeapon;
public int AddWeaponCount;

[Header("NormalFire")]
public GameObject NormalFire;
public int NormalFireCount;

[Header("Mana")]
public GameObject Mana;
public int ManaCount;

[Header("PiercingDamage")]
public GameObject PiercingDamage;
public int PiercingDamageCount;

[Header("Bomb")]
public GameObject Bomb;
public int BombCount;

[Header("Shield")]
public GameObject Shield;
public int ShieldCount;

[Header("Freeze")]
public GameObject Freeze;
public int FreezeCount;

[Header("Cleaner")]
public GameObject Cleaner;
public int CleanerCount;

[Header("UltimateDamage")]
public GameObject UltimateDamage;
public int UltimateDamageCount;

[Header("ManaDamage")]
public GameObject ManaDamage;
public int ManaDamageCount;

[Header("TakeTwo")]
public GameObject TakeTwo;
public int TakeTwoCount;

[Header("Heal")]
public GameObject Heal;
public int HealCount;

[Header("Mana Boost")]
public GameObject ManaBoost;
public int ManaBoostCount;




}
