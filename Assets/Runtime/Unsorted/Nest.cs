using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nest : Container
{
    Vector2[] vectorPositions;
    public Vector2 offset;
    public Vector2 startPos;

    /* private void Awake()
    {
        maxItems = 17;
        currentItems = new List<GameObject>();
        startPos = new Vector2(-7.75f, -3.5f);
        offset = new Vector2(1f, 0);
        vectorPositions = new Vector2[maxItems];
    }

    private void Start()
    {
        InitializePositions();

        StartCoroutine(InitializeSpawnedEggs());
    }

    void InitializePositions()
    {
        for (int i = 0; i < vectorPositions.Length; i++)
        {
            vectorPositions[i] = startPos + (offset * i);
        }
    }

    public Vector2 NextPos(Vector2 currentPos)
    {
        Vector2 temp = currentPos;
        if (IsContainable())
        {
            temp = vectorPositions[currentItems.Count-1];
        }

        return temp;
    }

    public void EggCollect(Egg obj)
    {
        PlaceItem(obj.gameObject);
        obj.destination = NextPos(transform.position);

        if (IsContainable())
        {
            obj.collected = true;
            obj.transform.parent = transform;
        }
    }

    IEnumerator InitializeSpawnedEggs()
    {
        yield return new WaitForSeconds(0.1f);
        Egg[] temp = GetComponentsInChildren<Egg>();
        for (int i = 0; i < temp.Length; i++)
        {
            temp[i].OnCollect();
        }
    }*/
}
