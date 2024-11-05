using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameUI gameUI; 
    public GameTimer gameTimer; 

    private void Start()
    {        
        StartGame();
    }

    
    public void StartGame()
    {        
        Debug.Log("Juego Comenzado");       
        gameUI.HideScreens();        
        gameTimer.StopTime();  
        gameTimer.ResetTime();        
    }

   
    public void RestartGame()
    {
        Debug.Log("Juego Reiniciado");              
        StartGame();
    }

    
    public void EndGame(bool victory)
    {        
        gameTimer.StopTime();        
        if (victory)
        {
            gameUI.VictoryScreen(gameTimer.GetTime());
        }
        else
        {
            gameUI.DefeatScreen();
        }        
    }
}
