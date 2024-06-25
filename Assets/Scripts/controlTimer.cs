using UnityEngine;
using TMPro;

public class controlTimer : MonoBehaviour
{
    public TextMeshProUGUI victoryText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "startRace")
        {
            setTimer(1);
        }

        if (other.gameObject.name == "finishRace")
        {
            setTimer(0);
            DisplayVictoryMessage();
            StopGame();
        }
    }

    void setTimer(int t)
    {
        Timer playerTimer = this.GetComponent<Timer>();
        playerTimer.startTimer = t;
    }

    void DisplayVictoryMessage()
    {
        if (victoryText != null)
        {
            victoryText.text = "Перемога!";
            victoryText.gameObject.SetActive(true);
        }
    }

    void StopGame()
    {
        Time.timeScale = 0f;
    }
}
