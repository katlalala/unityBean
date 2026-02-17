using UnityEngine;

public class BeanTestCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Donut"))
        {
            Object.FindFirstObjectByType<DonutCount>()?.AddScore(10);
            Destroy(other.gameObject); 
        }
        
        if (other.gameObject.name == "Building1")
        {
            return;
        }
    }
}