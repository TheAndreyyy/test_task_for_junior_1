using UnityEngine;

public class Enemy_controller : MonoBehaviour
{

    public Transform[] Waypoints;
    public float Move_speed;
    public int Next_waypoint = 0;
    public bool Go_back_to_first_waypoint;

    void Start()
    {
        transform.position = Waypoints[Next_waypoint].transform.position;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Waypoints.Length == 2)
        {
            //движение
            transform.position = Vector2.MoveTowards(transform.position, Waypoints[Next_waypoint].transform.position, Move_speed * Time.deltaTime);
            //если дошел до точки, то идем к следующей
            if (transform.position == Waypoints[Next_waypoint].transform.position)
            {
                if (Go_back_to_first_waypoint == false)
                {
                    if (Next_waypoint == Waypoints.Length - 1)
                    {
                        Go_back_to_first_waypoint = !Go_back_to_first_waypoint;
                        transform.Rotate(Vector3.up * 180);
                    }
                    else
                    {
                        Next_waypoint++;
                    }
                }
                else
                {
                    if (Next_waypoint == 0)
                    {
                        Go_back_to_first_waypoint = !Go_back_to_first_waypoint;
                        transform.Rotate(Vector3.up * 180);
                    }
                    else
                    {
                        Next_waypoint--;
                    }
                }
            }
        }
    }
}
