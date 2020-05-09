using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extend (HAS-A)
public class Spawner : MonoBehaviour
{
    private GameObject spawnItem;
    private bool destroyOnSpawn;

    //TODO: check errors and handle

    private bool IsActive()
    {
        return spawnItem != null;
    }

    private void Spawn()
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
