using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveConfig : ScriptableObject
{
    // Variables for configuration of waves of enemies
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 2f;

    // Function to get Enemy Prefab
    public GameObject GetEnemyPrefab() { return enemyPrefab; }

    // Function to get waypoints which the enemies will follow
    public List<Transform> GetWaypoints()
    {
        var waveWayPoints = new List<Transform>();
        foreach (Transform child in pathPrefab.transform)
        {
            waveWayPoints.Add(child);
        }
        return waveWayPoints;
    }

    // Function to get Time Between Spawns
    public float GetTimeBetweenSpawns() { return timeBetweenSpawns; }

    // Function to get Randomization factor for spawning enemies
    public float GetSpawnRandomFactor() { return spawnRandomFactor; }

    // Function to get the number of enemies
    public int GetNumberOfEnemies() { return numberOfEnemies; }

    // Function to get Move speed of enemy waves
    public float GetMoveSpeed() { return moveSpeed; }
}
