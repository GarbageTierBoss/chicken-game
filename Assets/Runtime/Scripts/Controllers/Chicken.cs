using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MovementController
{
    public GameObject egg;
    public float secsToLay = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LayEggs());
        StartCoroutine(Die());


        //RotationHandler.SetRandomRotation(transform);
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        direction = MovementHandler.CalcBounceVector(transform, direction);
    }*/

    IEnumerator LayEggs()
    {
        yield return new WaitForSeconds(secsToLay);

        Instantiate(egg, transform.position, Quaternion.identity);
        StartCoroutine(LayEggs());
    }

    /*private void OnMouseDown()
    {
        FindObjectOfType<ScoreController>().SellChicken();
        Destroy(gameObject);
    }*/

    IEnumerator Die()
    {
        yield return new WaitForSeconds(20f);
        Destroy(gameObject);
    }
}
