using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    //[SerializeField] float shootingSpeed = 5f;
    Rigidbody2D rb;
    GameObject bullet;
    [SerializeField] Camera cam;
    Vector2 mousePos;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
        {
            bullet = Instantiate(projectile, transform.position, Quaternion.identity);
        }
    }
    void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;     
    }
}
