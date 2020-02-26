using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour, IPlaceable
{
    public List<GameObject> items;
    public int maxItems = 0;

    public bool IsPlaceable()
    {
        return items.Count < maxItems;
    }

    public void ClearAll()
    {
        items.Clear();
    }

    public void PlaceItem(GameObject obj)
    {
        if (IsPlaceable())
        {
            items.Add(obj);
        }
    }

    public GameObject ItemAt(int index)
    {
        GameObject item = index < items.Count ? items[index] : null;
        return item;
    }
}
