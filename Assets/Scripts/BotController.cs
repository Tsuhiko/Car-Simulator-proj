using UnityEngine;
using TMPro;

public class BotController : MonoBehaviour
{
    public TextMeshProUGUI defeatText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "finishRace")
        {
            DisplayDefeatMessage();
            StopGame();
        }
    }

    void DisplayDefeatMessage()
    {
        if (defeatText != null)
        {
            defeatText.text = "Ви програли!";
            defeatText.gameObject.SetActive(true);
        }
    }

    void StopGame()
    {
        Time.timeScale = 0f;
    }
}
