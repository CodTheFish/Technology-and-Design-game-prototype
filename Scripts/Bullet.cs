using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 shootDir;
    public float speed;
    private void Awake()
    {
        Destroy(this.gameObject, 5f);
    }
    private void Update()
    {
        transform.position += shootDir * speed * Time.deltaTime;
    }
    private void OnTriggerEnter (Collider collider)
    {
        Debug.Log("hit");
        try
        {
            Debug.Log("player hit");
            collider.transform.parent.GetComponent<HealthManager>().health -= 30;
        }
        catch(NullReferenceException)
        {
            Destroy(this.gameObject);
        }
        
    }
}
