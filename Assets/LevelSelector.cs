using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void SelectLevel(int level)
    {
        Debug.Log("Nivel Seleccionado: " + level);
        SceneManager.LoadScene("Nivel 2");
    }
}
