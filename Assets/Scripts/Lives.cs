using UnityEngine;
using TMPro;

public class Lives : MonoBehaviour
{
    public TextMeshProUGUI livesText; 
    public int lives = 3;
    private bool isDead = false;

    void Start()
    {
        if(livesText != null) 
            livesText.text = "Atlikušās dzīvības: " + lives;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Bistams") && !isDead)
        {
            lives--;
            livesText.text = "Atlikušās dzīvības: " + lives;
            
            Destroy(other.gameObject);

            if (lives <= 0)
            {
                isDead = true;
                livesText.text = "Atlikušās dzīvības: 0";
                GameOver();
            }
        }
    }

    void GameOver()
    {
        Debug.Log("Spēle beigusies.");
        Object.FindFirstObjectByType<DonutCount>().StopTimer();
    }
}