using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int health = 100;
    public bool killable;
    public GameObject background;
    public GameObject player;
    private void Update()
    {
        if (health <= 0 && killable) 
        { 
            background.SetActive(true); 
            Cursor.lockState = CursorLockMode.None;
            player.GetComponent<FirstPersonController>().enabled = false;
            player.GetComponent<StarterAssetsInputs>().enabled = false;
        }
    }   

}
