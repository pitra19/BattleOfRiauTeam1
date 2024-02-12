using UnityEngine;
using System.Collections.Generic;

public class WaveRoute : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>(); // Daftar titik-titik rute

    // Fungsi untuk mengambil titik berikutnya dalam rute
    public Transform GetNextWaypoint(Transform currentWaypoint)
    {
        // Temukan indeks dari titik saat ini
        int currentIndex = waypoints.IndexOf(currentWaypoint);

        // Jika titik saat ini bukan titik terakhir dalam rute, kembalikan titik berikutnya
        if (currentIndex < waypoints.Count - 1)
        {
            return waypoints[currentIndex + 1];
        }
        // Jika titik saat ini adalah titik terakhir dalam rute, kembalikan null
        else
        {
            return null;
        }
    }
}