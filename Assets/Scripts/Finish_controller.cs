using UnityEngine;
using TMPro;

public class Finish_controller : MonoBehaviour
{
    public GameObject Win_screen_with_score;
    public GameObject Win_screen;
    public TextMeshProUGUI Score_text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("this score " + int.Parse(Score_text.text));
            print("saved score " + PlayerPrefs.GetInt("score"));

            if (PlayerPrefs.GetInt("score") == 0)//есть записи?
            {
                Win_screen_with_score.SetActive(true);//если записи нет (0 - значит нет), то он сто процентов поставил рекорд, открываем нужную таблицу
            }
            else
            if (int.Parse(Score_text.text) < PlayerPrefs.GetInt("score"))
            {
                Win_screen_with_score.SetActive(true);//запись есть, но у игрока результат лучше - также открываем нужную таблицу
            }
            else
            {
                Win_screen.SetActive(true);//сорян, но в таблице результат лучше, чем твой...
            }

            Time.timeScale = 0;//остановка игрового времени
        }
    }
}
