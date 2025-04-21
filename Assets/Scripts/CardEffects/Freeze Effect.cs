using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeEffect : MonoBehaviour, ICardEffect
{
    public CodeBlue codeBlue;

    void Start()
    {
        codeBlue = FindObjectOfType<CodeBlue>();
        
    }
    public void ApplyEffect()
    {
        codeBlue.Freeze = true;
    }

}
