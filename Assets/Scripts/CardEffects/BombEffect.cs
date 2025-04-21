using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BombEffect : MonoBehaviour, ICardEffect
{
    public CodeBlue codeBlue;
    void Start()
    {
        codeBlue = FindAnyObjectByType<CodeBlue>();
    }
    public void ApplyEffect()
    {
        Destroy(codeBlue.DestroyCannon);
    }

}
