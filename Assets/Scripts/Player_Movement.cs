using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 1.0f;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontalSpeed = Input.GetAxisRaw("Horizontal");
        float verticalSpeed = Input.GetAxisRaw("Vertical");
        Vector2 moveVector = new Vector2(horizontalSpeed, verticalSpeed);
        rb.MovePosition(rb.position + (moveVector.normalized * speed * Time.fixedDeltaTime));
    }
}
