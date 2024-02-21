using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f; // �������� ���� ������

    void Update()
    {
        // �������� �������� ������ ���������
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // ��� ������
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f) * speed * Time.deltaTime;
        transform.position += movement;
    }
}
