using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        if(view.IsMine)
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            Vector2 moveAmount = moveInput.normalized * speed * Time.deltaTime;
            transform.position += (Vector3)moveAmount;
        }
    }
}
