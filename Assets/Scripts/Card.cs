using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Cards Cards;
    [SerializeField] private TMP_Text cardName;
    [SerializeField] private Image cardImage;
    [SerializeField] private Image cardImage1;
    [SerializeField] private Image cardImage2;
    [SerializeField] private Image cardImage3;
    [SerializeField] private CardType cardType;
    [SerializeField] private TMP_Text manaCost;
    [SerializeField] private TargetType targetType;
    [HideInInspector] public int manaCostInt;

    public void Awake()
    {
        cardName.text = Cards.cardName;
        cardImage.sprite = Cards.cardImage;
        cardImage1.sprite = Cards.cardImage1;
        cardImage2.sprite = Cards.cardImage2;
        cardImage3.sprite = Cards.cardImage3;
        cardType = Cards.cardType;
        manaCost.text = Cards.manaCost.ToString();
        targetType = Cards.targetType;

        // mana int değeri
        manaCostInt = Cards.manaCost;

        switch(Cards.cardType)
        {
         case CardType.Damage:
            gameObject.AddComponent<DamageEffect>();
            break;
         case CardType.AddWeapon:
            gameObject.AddComponent<AddWeaponEffect>();
            Debug.Log("WeaponScript added: ");
            break;
         case CardType.Mana:
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
        case CardType.ManaBoost:
            gameObject.AddComponent<ManaBoostEffect>();
            break;
        case CardType.CardPick:
            gameObject.AddComponent<CardPickEffect>();
            break;
        
        }

    }

// Kartın hedef pozisyonunu ve rotasyonunu hesaplamak için değişkenler
[HideInInspector] public Transform parentToReturnTo = null;
private Vector3 targetPosition;
private float moveSpeedLimit = 900f;
private bool isDragging = false;

void Update()
{
    if (isDragging)
    {
    Vector2 direction = (targetPosition - (Vector3)transform.position).normalized;
    Vector2 velocity = direction * Mathf.Min(moveSpeedLimit, Vector2.Distance(transform.position, targetPosition) / Time.deltaTime);
    transform.Translate(velocity * Time.deltaTime);
    }
}

public void OnDrag(PointerEventData eventData)
{
    targetPosition = eventData.position;
}

public void OnBeginDrag(PointerEventData eventData)
{
    parentToReturnTo = this.transform.parent;
    this.transform.SetParent(this.transform.parent.parent);
    GetComponent<CanvasGroup>().blocksRaycasts = false;

    isDragging=true;
}

public void OnEndDrag(PointerEventData eventData)
{
    this.transform.SetParent(parentToReturnTo);
    GetComponent<CanvasGroup>().blocksRaycasts = true;

    isDragging=false;
}



}
