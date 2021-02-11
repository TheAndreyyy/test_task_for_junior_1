using UnityEngine;

public class Camera_controller : MonoBehaviour
{
    public Transform Target;

    public float Smooth_speed = 0.125f;//скорость плавного смещения камеры
    public Vector3 Offset_for_camera;//смещение позиции камеры (чтобы нормально подобрать ракурс, иначе придется менять из кода)

    void LateUpdate()
    {
        if (transform.position.x < Target.position.x + Offset_for_camera.x)
        {
            float Desired_position = Target.position.x + Offset_for_camera.x;
            float Smoothed_position = Mathf.Lerp(transform.position.x, Desired_position, Smooth_speed * Time.smoothDeltaTime);//умножая на тайм - убираем дебильные подергивания при движении камеры/игрока
            transform.position = new Vector3(Smoothed_position, transform.position.y, transform.position.z);
        }
    }
}
