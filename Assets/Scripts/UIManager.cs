using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;

    // Start is called before the first frame update
    void Start()
    {
        //poner el score en cero
        UpdateScore(0);
    }

   public void UpdateScore(int score)
   {
        txtScore.text = "Score: " + score.ToString();   //actualizar el texto score
   }
}
