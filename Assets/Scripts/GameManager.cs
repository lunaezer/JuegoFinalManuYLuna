using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Para el reinicio

public class GameManager : MonoBehaviour
{
    [Header("Referencias UI")]
    public TextMeshProUGUI txtTime;
    public UIManager uiManager; // Necesitamos hablar con el UI para mostrar los paneles
    public InteractionArea InterArea;

    [Header("Configuración de Juego")]
    public float time = 60f;
    public int scoreWin = 2; 
    
    private bool gameEnded = false;

    void Awake()
    {
        // Importante: para que al reiniciar el juego no empiece pausado
        Time.timeScale = 1f;
    }

    void Update()
    {
        // Lógica de Reinicio: Si el juego terminó y apretás R
        if (gameEnded)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            return; // Si terminó, no hace nada de lo de abajo
        }

        ManejarTiempo();
        
    }

    void ManejarTiempo()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            txtTime.text = "Time: " + time.ToString("F2");
        }
        else
        {
            time = 0;
            txtTime.text = "Time: 0.00";
            GameOver(); // Perdiste por tiempo
        }
    }

    // El InteractionArea llamará a esta función pasando su score actual
    public void CheckWin(int scoreActual)
    {
        Debug.Log("Entro a checkwin. Score: " + scoreActual);
        if (scoreActual >= scoreWin)
        {
            WinGame();
            Debug.Log("gane");
        }
    }

    void WinGame()
    {
        gameEnded = true;
        Time.timeScale = 0f; // Congela el movimiento
        uiManager.MostrarPantallaWin(); // Activa el cartel de Ganaste
        Debug.Log("Entro a Win Game");
    }

    void GameOver()
    {
        gameEnded = true;
        Time.timeScale = 0f; // Congela el movimiento
        uiManager.MostrarPantallaGameOver(); // Activa el cartel de Perdiste
    }
}