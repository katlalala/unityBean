using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float currentTime = 0f;
    private bool isTimerRunning = false;

    void Update()
    {
        if (isTimerRunning)
        {
            currentTime += Time.deltaTime;
            DisplayTime(currentTime);
        }
    }

    public void StartTimer()
    {
        currentTime = 0f;
        isTimerRunning = true;
    }

    public void StopTimer()
    {
        isTimerRunning = false;
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
