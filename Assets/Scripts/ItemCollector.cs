using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public static int bubbles = 0;
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bubble")){
            ScoreManager.scoreValue += 1;
            Destroy(collision.gameObject);
            bubbles++;
            Debug.Log("Bubbles: " + bubbles);
        }
           
    }
}
