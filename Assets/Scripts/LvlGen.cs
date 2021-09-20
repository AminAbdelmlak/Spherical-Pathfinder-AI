using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LvlGen : MonoBehaviour
{

    public NavMeshSphere navMeshSphere;
    public Transform Planet;
    public int radius = 10;
    public int numOfWalls;
    public GameObject wall;


    // Use this for initialization
    void Start()
    {
        GenerateLevel();
    }

    // Create a grid based level
    void GenerateLevel()
    {
        for (int i = 0; i < numOfWalls; i++)
        {
            Vector3 SpawnPos = Random.onUnitSphere * (radius * .5f) + Planet.position;
            GameObject _wall = Instantiate(wall, SpawnPos, Quaternion.identity);
            _wall.transform.LookAt(Planet.position);
            _wall.transform.Rotate(90, 0, 0);
        }
    }
}