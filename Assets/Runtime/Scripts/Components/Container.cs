using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inherit (IS-A)
public class Container : MonoBehaviour
{
    public List<GameObject> currentItems;
    public int maxItems = 0;

    //TODO: check conditions and error handling for all methods

    public bool IsContainable()
    {
        return currentItems.Count < maxItems;
    }

    public void PlaceItem(GameObject obj)
    {
        if (IsContainable())
        {
            currentItems.Add(obj);
        }
    }

    public GameObject ItemAt(int index)
    {
        GameObject item = index < currentItems.Count ? currentItems[index] : null;
        return item;
    }

    public void ClearAll()
    {
        currentItems.Clear();
    }
}
