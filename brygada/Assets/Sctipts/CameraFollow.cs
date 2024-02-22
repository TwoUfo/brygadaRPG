using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 playerVector;
    public int speed;
    

    void LateUpdate()
    {
        playerVector = player.position;
        playerVector.z = -4;
        transform.position = Vector3.Lerp(transform.position, playerVector, speed*Time.deltaTime);
    }
}
