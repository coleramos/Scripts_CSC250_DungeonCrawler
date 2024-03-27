using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pelletController : MonoBehaviour
{
    public GameObject northExit;

    // Name of the fight scene to load
    public string fightSceneName = "FightScene";

    // Function to handle collisions with pellets
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Load the fight scene
            SceneManager.LoadScene(fightSceneName);
        }
        else if (other.CompareTag("power-pellet"))
        {
            other.gameObject.SetActive(false); //visually make pellet disappear

            //programatically make sure the pellet doesn't show up again
            Room theCurrentRoom = MySingleton.thePlayer.getCurrentRoom();
            // Assuming pelletController has a 'direction' property
            string pelletDirection = other.GetComponent<pelletController>().direction;
            theCurrentRoom.removePellet(pelletDirection); // Make sure this method expects a direction parameter
        }
        
    }
}