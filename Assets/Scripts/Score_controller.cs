using UnityEngine;
using TMPro;

public class Score_controller : MonoBehaviour
{
    public TextMeshProUGUI player_name;
    public TextMeshProUGUI score;

    public void Save_score()
    {
        PlayerPrefs.SetInt("score", int.Parse(score.text));
        print(player_name.text);
        print(score.text);
        if (player_name.text == "​")
        {
            PlayerPrefs.SetString("player_name", "Anonym");
        }
        else
        {
            PlayerPrefs.SetString("player_name", player_name.text);
        }
    }
}
