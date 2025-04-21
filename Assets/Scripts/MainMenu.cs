using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject Creditspanel;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame(){
        SceneManager.LoadScene("SampleScene");
    }

    public void Endgame(){
         Application.Quit();
    }

    public void Credits(){
        Creditspanel.SetActive(true);
    }
    public void CreditsOff(){
        Creditspanel.SetActive(false);
    }

}
