using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Transform cam;
    Vector3 offset = new Vector3(0, 1, -4);
    
    // Update is called once per frame
    void Update()
    {
        cam.position = player.position + offset;
    }
}
