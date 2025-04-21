using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class ShipHP : MonoBehaviour
{
    /*
    [SerializeField] private Image healthBar;
    public static ShipHP Instance { get; private set; }
    public float MaxHP = 100;
    public static float CurrentHP;

     private void Awake()
    {
        // Singleton örneğini ayarla.
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Multiple Ship instances in the scene! Destroying extra instance.");
            Destroy(gameObject); // Sahnede birden fazla Ship varsa, ekstra olanı yok et.
        }
    }

    void Start()
    {
        CurrentHP = MaxHP;
        UpdateHealth(CurrentHP, MaxHP);
    }
    void Update()
    {
        UpdateHealth(CurrentHP, MaxHP);
        Debug.Log(CurrentHP);
    }

    public void UpdateHealth(float CurrentHP, float MaxHP)
    {
        healthBar.fillAmount = CurrentHP / MaxHP;
    }
    */
}
