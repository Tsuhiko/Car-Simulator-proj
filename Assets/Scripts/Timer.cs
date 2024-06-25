using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerLabel;
    public float startTimer = 0;

    private float time;
    private float displayTime;

    void Update()
    {
        if (startTimer > 0)
        {
            time += Time.deltaTime;

            displayTime = Mathf.Lerp(displayTime, time, 0.1f);

            var minutes = (int)Mathf.Floor(displayTime / 60);
            var seconds = (int)(displayTime % 60);
            var fraction = (int)((displayTime * 100) % 100);

            timerLabel.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
        }
        else
        {

        }
    }
}
