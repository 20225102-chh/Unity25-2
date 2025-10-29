using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float dropSpeed = 0.1f;
    public float arrowRadius = 0.3f;
    public float playerRadius = 0.7f;

    Transform playerTransform;
    private void Start()
    {
        playerTransform = GameObject.Find("player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.Translate(0, -dropSpeed, 0);

        if(transform.position.y <-7f)
        {
            Destroy(gameObject);
        }

        CheckCollision();

    }

    void CheckCollision()
    {
        Vector2 arrowPosition = transform.position;
        Vector2 playerPosition = playerTransform.position;
        float distance = (arrowPosition - playerPosition).magnitude;

        if(distance < arrowRadius + playerRadius)
        {
            Destroy(gameObject);
        }
    }
}
