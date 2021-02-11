using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI_controller : MonoBehaviour
{
    public float Timer_start;
    public TextMeshProUGUI Timer_text_score;

    public GameObject character_controller;
    public GameObject Lose_board;

    public Character_controller scr_character_controller;

    void Start()
    {
        Timer_text_score.text = Timer_start.ToString();
        scr_character_controller = character_controller.GetComponent<Character_controller>();
    }

    void Update()
    {
        if (scr_character_controller.first_motion)
        {
            Timer_start += Time.deltaTime;
            Timer_text_score.text = Mathf.Round(Timer_start).ToString();
        }
    }

    public void Exit_to_menu()
    {
        SceneManager.LoadScene("Main_menu");
        Time.timeScale = 1;
    }

    public void Restart_level()
    {
        SceneManager.LoadScene("Game_scene");
        Time.timeScale = 1;
    }

    public void Pause_game()
    {
        Time.timeScale = 0;
    }

    public void Resume_game()
    {
        Time.timeScale = 1;
    }

    public void Game_over()
    {
        Lose_board.gameObject.SetActive(true);
        Pause_game();
    }
}
