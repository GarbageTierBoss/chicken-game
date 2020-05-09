using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inherit (IS-A)
public abstract class Container : MonoBehaviour
{
    private List<IContainable> currentItems;
    private int maxItems = 0;

    //TODO: check conditions and error handling for all methods

    private bool IsContainable()
    {
        return currentItems.Count < maxItems;
    }

    private void AddItem(IContainable obj)
    {
        if (IsContainable())
        {
            currentItems.Add(obj);
        }
    }

    private IContainable ItemAt(int index)
    {
        IContainable item = index < currentItems.Count ? currentItems[index] : null;
        return item;
    }

    private void ClearAll()
    {
        currentItems.Clear();
    }
}
