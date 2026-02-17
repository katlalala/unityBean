using UnityEngine;
using TMPro;

public class DonutCount : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public AudioSource soundPlayer; 
    public AudioClip collectSound;

    private int score = 0;
    private bool gameActive = false;

    
    public void StartGame()
    {
        score = 0;
        gameActive = true;
        scoreText.text = "Virtuļi: 0";
        Debug.Log("Spēle sākas");
    }

    
    public void StopTimer() 
    {
        gameActive = false;
        Debug.Log("Kopējie punkti: " + score);
    }

    public void AddScore(int amount)
    {
        
        if (!gameActive) return;

        score += amount;
        scoreText.text = "Virtuļi: " + score;
        
        if (soundPlayer != null && collectSound != null)
            soundPlayer.PlayOneShot(collectSound);
    }
}