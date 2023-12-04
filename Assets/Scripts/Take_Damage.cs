using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Take_Damage : MonoBehaviour
{
    public float health = 100;
    public void Damage(float damage)
    {
        health -= damage;
        if (health <= 0) Destroy(this.gameObject);
        Debug.Log(health);
    }
}
