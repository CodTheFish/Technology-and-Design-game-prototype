using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public GameObject enemy;
    [SerializeField] GameObject spawnpoints;
    void Start()
    {
        FindSpawnPoints();
    }
    void FindSpawnPoints()
    {
        int enemyNum = spawnpoints.transform.childCount;
        for (int i = 1; i < enemyNum + 1; i++)
        {
            UnityEngine.Vector3 spawnLocation = GameObject.Find("point" + i).GetComponent<Transform>().position;
            GameObject enemyClone = Instantiate(enemy, new UnityEngine.Vector3(spawnLocation.x, spawnLocation.y, spawnLocation.z), enemy.transform.rotation);
        }
    }
}
