using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed = 0.5f;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       body.velocity = new Vector2(body.velocity.x + speed * Time.deltaTime, body.velocity.y);
    }
}
