using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float currentTime; // Current time elapsed
    private TextMeshProUGUI timerText; // Reference to the TextMeshPro text component

    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        currentTime = 0f;
    }

    void Update()
    {
        // Update the timer
        currentTime += Time.deltaTime;

        // Format the time as minutes:seconds
        string minutes = Mathf.Floor(currentTime / 60).ToString("00");
        string seconds = Mathf.Floor(currentTime % 60).ToString("00");

        // Update the TextMeshPro text
        timerText.text = minutes + ":" + seconds;
    }
}