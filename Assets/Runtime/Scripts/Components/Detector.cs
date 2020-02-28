using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extend (HAS-A)
public class Detector : MonoBehaviour
{
    public float range = 0;
    public string layer;

    public float interval = 0;

    public int maxDetect = 3;
    public int resultCount = 0;

    public Vector3 offset = Vector3.zero;
    public Collider2D[] inRange;

    //TODO: Initialize()
    //TODO: Rigidbody2D version
    //TODO: 2D exclusive script?
    //TODO: comment... efficiency?
    //TODO: need to stop coroutine

    public bool IsDetecting()
    {
        return range > 0 && interval >= 0;
    }

    public virtual void Detect()
    {
        resultCount = Physics2D.OverlapCircleNonAlloc(transform.position + offset, range, inRange, LayerMask.GetMask(layer));
    }

    public IEnumerator DetectOnInterval()
    {
        yield return new WaitForSeconds(interval);

        Detect();

        StartCoroutine(DetectOnInterval());
    }
}
