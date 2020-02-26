using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlaceable
{
    bool IsPlaceable();
    void ClearAll();

    void PlaceItem(GameObject obj);
}
