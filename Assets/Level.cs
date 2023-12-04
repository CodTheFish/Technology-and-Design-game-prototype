using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] GameObject level1, level2, level3, level4, level5;
    List<GameObject> levels = new List<GameObject>();
    public int levelNum;
    private void Awake()
    {
        levels.Add(level1);
        levels.Add(level2);
        levels.Add(level3);
        levels.Add(level4);
        levels.Add(level5);

        GenerateLayout(levelNum);
    }
    private void GenerateLayout(int levelNum)
    {
        for(int i = 1; i <= levelNum; i++)
        {
            GameObject generatedLevel = levels[UnityEngine.Random.Range(0, levels.Count)];
            GameObject realLevel = Instantiate(generatedLevel, GameObject.Find("Level").transform);
            realLevel.transform.position += new Vector3(0, 0, transform.position.z + (35 * i));
        }
    }
}
