using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using GryffinBork;

public class Egg : MovementController
{
    public static UnityEvent onEggCollect;
    public static UnityEvent onEggActive;
    public bool collected = false;
    public Vector2 destination;
    public Nest nest;

    public GameObject chicken;

    public float timeTillHatch = 2f;

    public bool hatch;
    Vector3[] waypoints = new Vector3[2];

    private void Start()
    {
        nest = FindObjectOfType<Nest>();
        speed = 15;
        onEggCollect = onEggCollect ?? new UnityEvent();
    }

    private void Update()
    {
        if (collected)
        {
            transform.position = MovementHandle2D.NextPositionTowards(transform.position, destination, speed);
        }
    }

    public IEnumerator JumpToPos(Vector2 pos)
    {
        yield return new WaitForSeconds(0.2f);

        transform.position = pos;

        if (transform.position == waypoints[0])
        {
            StartCoroutine(JumpToPos(waypoints[1]));
        }
        
        if (transform.position == waypoints[1])
        {
            StartCoroutine(JumpToPos(waypoints[0]));
        }
    }

    public void OnMouseOver()
    {
        if (!collected && transform.parent != nest.transform && !hatch)
        {
            onEggCollect.Invoke();
            OnCollect();
        }
    }

    private void OnMouseUpAsButton()
    {
        hatch = true;
        collected = false;
        //nest.currentItems.Remove(gameObject);
        transform.parent = null;
        waypoints[0] = transform.position + (Vector3.left * 0.04f);
        waypoints[1] = transform.position + (Vector3.right * 0.04f);

        if (hatch)
        {
            StartCoroutine(JumpToPos(waypoints[0]));
            StartCoroutine(Hatch());
        }
    }

    IEnumerator Hatch()
    {
        yield return new WaitForSeconds(timeTillHatch);

        Instantiate(chicken, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void OnCollect()
    {
        //nest.EggCollect(GetComponent<Egg>());
    }
}
