using System.Collections;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private float destroyDelay = 1f;

    [SerializeField] private Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Break());
        }
    }

    private IEnumerator Break()
    {
        yield return new WaitForSeconds(destroyDelay);
        Destroy(gameObject);
    }
}