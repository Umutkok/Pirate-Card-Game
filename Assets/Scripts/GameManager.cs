using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [HideInInspector] public int shipCannonNumber = 1;
    public Image shield;
    private Coroutine ManaCorotine;

    [Header("Health")]
    [SerializeField] private Image healthBar;
    public static float HP = 100;
    public float shiphealt = 100;
    public TMP_Text HealthUI;

    [Header("Mana")]
    [SerializeField] private Image manaBar;
    public TMP_Text ManaUI;
    public float MaxMana = 50;
    public float currentMana = 20;

    [Header("Sunum")]
    [SerializeField] private Image RedhealthBar;
    public TMP_Text RedHealthUI;
    public static float RedHP = 100;
    public float Redshiphealt = 25;


    void Start()
    {
        shiphealt = HP;
        UpdateHealth(shiphealt, HP);
        ManaCorotine = StartCoroutine(ManaIncrease());
    }
    void Update()
    {
        UpdateHealth(shiphealt, HP);
        UpdateMana(MaxMana,currentMana);

        RedUpdateHealth(Redshiphealt,RedHP);//sil

        Debug.Log(shiphealt); //DeBUG
    }

    public void UpdateHealth(float shiphealt, float HP)
    {
        healthBar.fillAmount = shiphealt / HP;
        HealthUI.text = (shiphealt.ToString());
    }
    public void UpdateMana(float MaxMana, float currentMana)
    {
        ManaUI.text = (MaxMana.ToString() + "/" + currentMana.ToString());
        manaBar.fillAmount = currentMana / MaxMana;
    }

    private IEnumerator ManaIncrease()
    {
        while(currentMana<50)
        {
            yield return new WaitForSeconds(3);
            currentMana += 1;
        }
    }

    //sil
    public void RedUpdateHealth(float Redshiphealt, float RedHP)
    {
        RedhealthBar.fillAmount = Redshiphealt / RedHP;
        RedHealthUI.text = (Redshiphealt.ToString());
    }


    
}
