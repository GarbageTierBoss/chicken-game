using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extend (HAS-A)
public class Spawner : MonoBehaviour
{
    public GameObject spawnItem;
    public bool destroyOnSpawn;

    //TODO: check errors and handle

    public bool IsActive()
    {
        return spawnItem != null;
    }

    public void Spawn()
    {
        if (IsActive())
        {
            Instantiate(spawnItem);

            if (destroyOnSpawn)
            {
                Destroy(gameObject);
            }
        }
    }
}
