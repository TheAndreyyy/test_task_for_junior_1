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

            if (PlayerPrefs.GetInt("score") == 0)//���� ������?
            {
                Win_screen_with_score.SetActive(true);//���� ������ ��� (0 - ������ ���), �� �� ��� ��������� �������� ������, ��������� ������ �������
            }
            else
            if (int.Parse(Score_text.text) < PlayerPrefs.GetInt("score"))
            {
                Win_screen_with_score.SetActive(true);//������ ����, �� � ������ ��������� ����� - ����� ��������� ������ �������
            }
            else
            {
                Win_screen.SetActive(true);//�����, �� � ������� ��������� �����, ��� ����...
            }

            Time.timeScale = 0;//��������� �������� �������
        }
    }
}
