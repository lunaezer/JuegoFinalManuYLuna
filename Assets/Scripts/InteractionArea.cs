using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public int score = 0;
    public UIManager uiManagerScript;
    public GameManager gameManager; // Referencia al GameManager

    void Awake()
    {
        uiManagerScript = GameObject.FindObjectOfType<UIManager>();
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            score++;
            uiManagerScript.UpdateScore(score);
            
            // Le avisamos al GameManager para que vea si ganamos
            gameManager.CheckWin(score);
        }
    }
}
