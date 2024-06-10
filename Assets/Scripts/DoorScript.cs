using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    private bool playerNearDoor = false; // Flag to check if player is near the door

    void Update()
    {
        // Check if the player is near the door and the 'E' key is pressed
        if (playerNearDoor && Input.GetKeyDown(KeyCode.E))
        {
            // Load the death scene
            SceneManager.LoadScene("DoorDeath"); // Replace "DeathScene" with the actual name of your death scene
        }
    }

    // Detect when the player enters the trigger collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Assumes the player has the tag "Player"
        {
            playerNearDoor = true;
        }
    }

    // Detect when the player exits the trigger collider
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearDoor = false;
        }
    }
}
