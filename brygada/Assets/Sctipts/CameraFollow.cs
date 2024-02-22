using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Посилання на об'єкт гравця

    public float smoothSpeed = 0.125f; // Параметр для згладжування руху

    public Vector3 offset; // Відстань між камерою і гравцем

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // Обчислюємо нову позицію камери

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Згладжуємо рух

        transform.position = smoothedPosition; // Задаємо нову позицію камери
    }
}
