using UnityEngine;

public class ObjectDropper : MonoBehaviour
{
    public GameObject objectToDrop; // Objek yang akan dijatuhkan

    void Start()
    {
        DropObject();
    }

    void DropObject()
    {
        // Menginstansiasi objek dan meletakkannya di posisi awalnya (0, 10, 0)
        Instantiate(objectToDrop, new Vector3(0f, 10f, 0f), Quaternion.identity);
    }
}