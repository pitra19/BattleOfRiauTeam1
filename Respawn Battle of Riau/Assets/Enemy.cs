using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100f; // Nyawa musuh

    // Fungsi untuk menerima kerusakan dari pemain atau senjata lainnya
    public void TakeDamage(float damage)
    {
        health -= damage; // Mengurangi nyawa musuh sesuai dengan jumlah kerusakan yang diterima

        // Jika nyawa musuh habis, panggil fungsi Die()
        if (health <= 0f)
        {
            Die();
        }
    }

    // Fungsi untuk menghapus musuh dari permainan
    void Die()
    {
        Destroy(gameObject); // Menghapus objek musuh dari permainan
    }
}