using UnityEngine;

public class ObjekSpawner : MonoBehaviour
{
    public GameObject objekToSpawn; // Objek yang akan di-spawn
    public Transform spawnPoint; // Titik spawn untuk objek

    // Fungsi untuk meng-spawn objek
    public void SpawnObject()
    {
        // Memeriksa apakah objekToSpawn dan spawnPoint telah diatur
        if (objekToSpawn != null && spawnPoint != null)
        {
            // Meng-instantiate objek pada posisi dan rotasi spawnPoint
            Instantiate(objekToSpawn, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            // Jika objekToSpawn atau spawnPoint belum diatur, tampilkan pesan kesalahan
            Debug.LogError("ObjekToSpawn atau SpawnPoint belum diatur!");
        }
    }
}