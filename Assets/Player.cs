using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int life = 3;

    public void TakeDamage(int damage)
    {
        life -= damage;
        CheckGameOver();
    }

    private void CheckGameOver()
    {
        if (life <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {       
        Debug.Log("Game Over");
    }
}
