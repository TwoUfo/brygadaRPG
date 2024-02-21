using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f; // Ўвидк≥сть руху гравц€

    void Update()
    {
        // ќтримуЇмо значенн€ в≥джет≥в управл≥нн€
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // –ух гравц€
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f) * speed * Time.deltaTime;
        transform.position += movement;
    }
}
