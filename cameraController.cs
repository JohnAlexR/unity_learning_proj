using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Transform chaser;
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;
    public Camera cam;

      void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        // transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed * Time.deltaTime);
        if (player.position.x <= chaser.position.x)
        {
            cam.backgroundColor = Color.red; // Change background to red
        }
        else
        {
            cam.backgroundColor = Color.blue; // Change background to white or any other default color
        }
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);

    }
}


