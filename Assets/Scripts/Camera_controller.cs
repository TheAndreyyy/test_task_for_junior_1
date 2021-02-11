using UnityEngine;

public class Camera_controller : MonoBehaviour
{
    public Transform Target;

    public float Smooth_speed = 0.125f;//�������� �������� �������� ������
    public Vector3 Offset_for_camera;//�������� ������� ������ (����� ��������� ��������� ������, ����� �������� ������ �� ����)

    void LateUpdate()
    {
        if (transform.position.x < Target.position.x + Offset_for_camera.x)
        {
            float Desired_position = Target.position.x + Offset_for_camera.x;
            float Smoothed_position = Mathf.Lerp(transform.position.x, Desired_position, Smooth_speed * Time.smoothDeltaTime);//������� �� ���� - ������� ��������� ������������ ��� �������� ������/������
            transform.position = new Vector3(Smoothed_position, transform.position.y, transform.position.z);
        }
    }
}
