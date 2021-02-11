using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI Text_score;

    void Start()
    {
        if (PlayerPrefs.HasKey("score"))
        {
            Text_score.text = PlayerPrefs.GetString("player_name") + ":" + " " + PlayerPrefs.GetInt("score");
        }
    }

    public void Exit_game()
    {
        print("EXIT");
        Application.Quit();
    }
}
