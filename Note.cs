using System.Collections;
using UnityEngine;

public class Note : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Score scoreScript;

     private void Awake()
    {
        //like document.querySelector in JS but finds the Rigidbody component 
        //attached to the same GameObj as the script
        body = GetComponent<Rigidbody2D>();
        scoreScript = FindObjectOfType<Score>();
    }

      void Update()
    {
        body.velocity = new Vector2(body.velocity.x - speed * Time.deltaTime, body.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Note collided");
            if(scoreScript != null){
                scoreScript.AddScore();
            }
            Destroy();
            
        }
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}