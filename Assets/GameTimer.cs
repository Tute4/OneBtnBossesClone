using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    private float gameTime;
    private bool TimeRunning = false;

    private void Update()
    {
        if (TimeRunning)
        {
            gameTime += Time.deltaTime;  
            MostrarTiempo();
        }
    }

    private void MostrarTiempo()
    {
        
        Debug.Log("Tiempo: " + gameTime.ToString("F2"));
    }

    public void StopTime()
    {        
        TimeRunning = false;
    }

    public void ResetTime()
    {       
        gameTime = 0f;
        TimeRunning = true;
    }

    public float GetTime()
    {
        return gameTime;
    }
}
