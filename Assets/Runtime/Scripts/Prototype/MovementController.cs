using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GryffinBork;

public class MovementController : MonoBehaviour
{
    public Vector2 direction;
    public float speed = 0;
    public float castOffset = 0.5f;

    public bool rbExists;
    public bool bounce;
    public bool move;

    protected Rigidbody2D rb;

    void Awake()
    {
        speed = speed == 0 ? 2 : speed;    // if speed == 0, then make speed 2
        direction = MovementHandle2D.SetRandomDir();
        Debug.Log(direction);
        Debug.Log(direction.magnitude);
    }

    void Start()
    {
        rbExists = GetComponent<Rigidbody2D>() ? true : false;
        rb = rb ?? GetComponent<Rigidbody2D>(); // if null, assign
    }

    void FixedUpdate()
    {
        if (move)
        {
            Move();
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        direction = bounce ? MovementHandle2D.SetRandomDir() : direction;
    }

    void OnMouseDrag()
    {
        if (rbExists)
        {
            MovementHandle2D.StickToMouse(rb);
        }
        else
        {
            MovementHandle2D.StickToMouse(transform);
        }
    }

    void Move()
    {
        if (rbExists)
        {
            rb.position = MovementHandle2D.GetPosInDir(rb.position, direction, speed);
        }
        else
        {
            transform.position = MovementHandle2D.GetPosInDir(transform.position, direction, speed);
        }
    }
}
