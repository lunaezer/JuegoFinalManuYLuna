using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    
    [Header("Paneles de Fin de Juego")]
    public GameObject panelWin;
    public GameObject panelGameOver;

    void Start()
    {
        UpdateScore(0);
        // Nos aseguramos de que empiecen desactivados por código también
        panelWin.SetActive(false);
        panelGameOver.SetActive(false);
    }

    public void UpdateScore(int score)
    {
        txtScore.text = "Score: " + score.ToString();
    }

    public void MostrarPantallaWin()
    {
        panelWin.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        panelGameOver.SetActive(true);
    }
}

