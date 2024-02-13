using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab untuk musuh
    public Transform spawnPoint; // Posisi spawner
    public float timeBetweenWaves = 5f; // Waktu antara gelombang musuh
    public float timeBetweenEnemies = 0.5f; // Waktu antara munculnya musuh dalam satu gelombang
    public int enemiesPerWave = 5; // Jumlah musuh dalam satu gelombang
    private int waveNumber = 0; // Nomor gelombang

    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    IEnumerator SpawnWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenWaves);
            waveNumber++;
            Debug.Log("Wave " + waveNumber + " incoming!");

            for (int i = 0; i < enemiesPerWave; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(timeBetweenEnemies);
            }
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}