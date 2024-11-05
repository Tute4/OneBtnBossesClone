using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameObject Victory;  
    public GameObject Defeat;   

    
    public void VictoryScreen(float Time)
    {
        Victory.SetActive(true);        
        Debug.Log("Victoria! Tiempo: " + Time);        
    }

    
    public void DefeatScreen()
    {
        Defeat.SetActive(true);
        Debug.Log("Derrota!");
    }

    
    public void HideScreens()
    {
        Victory.SetActive(false);
        Defeat.SetActive(false);
    }
}
