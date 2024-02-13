using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Prefab objek yang akan di-spawn
    public Transform spawnPoint; // Posisi tempat spawn objek

    public void SpawnObject()
    {
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}