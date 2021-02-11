using UnityEngine;

public class Character_controller : MonoBehaviour
{
    public float Walk_force;
    public float Walk_end_force;
    public int Jump_force;
    public bool first_motion;
    public Rigidbody2D Character_rb;
    public float Offset_screen;//смещение левой "границы" экрана, за которую персонажу уходить нельзя

    public bool On_ground;
    public Transform Ground_check;

    void Start()
    {
        Character_rb = GetComponent<Rigidbody2D>();
        Walk_end_force = Walk_force;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        //ходьба в стороны
        switch (Input.GetAxisRaw("Horizontal"))
        {
            case 1:
                {
                    if (Input.GetKeyDown(KeyCode.LeftShift))
                    {
                        Walk_end_force = Walk_end_force * 1.5f;
                    }
                    transform.Translate(Vector2.right * Walk_force * Time.smoothDeltaTime);
                    transform.eulerAngles = new Vector2(0, 0);
                    if (first_motion == false)
                    {
                        first_motion = true;
                    }
                }
                break;
            case -1:
                {
                    if (transform.position.x > Camera.main.gameObject.transform.position.x - Offset_screen)
                    {
                        transform.Translate(Vector2.left * Walk_force * Time.smoothDeltaTime);
                    }
                    if (first_motion == false)
                    {
                        first_motion = true;
                    }
                }
                break;
        }
        //прыжок
        On_ground = Physics2D.OverlapCircle(Ground_check.position,0.2f);
        if (Input.GetKeyDown(KeyCode.Space) && On_ground)
        {
            Character_rb.velocity = new Vector2(Character_rb.velocity.x, Jump_force);
            if (first_motion == false)
            {
                first_motion = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            UI_controller script_from_UI = GameObject.Find("Canvas").GetComponent<UI_controller>();
            script_from_UI.Game_over();
        }
    }
}
