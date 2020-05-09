using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extend (HAS-A)
public class Detector : MonoBehaviour
{
    private float detectionRange = 0;
    private string detectionLayer;

    //private float detectInterval = 0; should be handled outside

    private int maxItemsToDetect = 3;
    private int numberDetected = 0;

    private Vector3 offset = Vector3.zero;
    private Collider2D[] itemsDetected;

    //TODO: Initialize()
    //TODO: Rigidbody2D version
    //TODO: 2D exclusive script?
    //TODO: comment... efficiency?
    //TODO: need to stop coroutine

    public bool IsDetecting()
    {
        return detectionRange > 0;//&& detectInterval >= 0;
    }

    public virtual void Detect()
    {
        numberDetected = Physics2D.OverlapCircleNonAlloc(transform.position + offset, detectionRange, itemsDetected, LayerMask.GetMask(detectionLayer));
    }

    /*public IEnumerator DetectOnInterval()
    {
        yield return new WaitForSeconds(detectInterval);

        Detect();

        StartCoroutine(DetectOnInterval());
    }*/
}
