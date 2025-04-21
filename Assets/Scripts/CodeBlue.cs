using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class CodeBlue : MonoBehaviour
{
    public bool Freeze = false;
    Renderer rend;
    public Material IceMaterial;
    public Material BaseMaterial;
    public GameObject DestroyCannon;
    public Animator anim;

    void Start()
    {
        rend = GetComponent<Renderer> ();
    }
    void Update()
    {
        if(Freeze==true)
        {
            anim.enabled = false;
            rend.material = IceMaterial;
            StartCoroutine(ShieldTime());
            IEnumerator ShieldTime()
            {
                yield return new WaitForSeconds(10);
                Freeze = false;
                anim.enabled = true;
                if(Freeze == false)
                {
                    gameObject.GetComponent<Renderer>().material = BaseMaterial;
                }
            }
        }
    }
}
