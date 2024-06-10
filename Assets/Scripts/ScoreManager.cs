using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int scoreValue = 0;
    public TMP_Text score; // Reference to the Text component displaying the score

    private void Start()
    {
        if (score == null)
        {
            score = GetComponent<TMP_Text>();
        }

       
        if (score == null)
        {
            Debug.LogError("Text component is not assigned or found in the GameObject.");
        }
    }

     void Update()
    {
        if(score != null)
        {
            score.text = "Gathered bubbles: " + scoreValue;
        }
       
    }
}
