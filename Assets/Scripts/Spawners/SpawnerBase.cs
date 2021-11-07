using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnerBase : MonoBehaviour {
    public GameObject prefab;
    private List<GameObject> objects = new List<GameObject>();

    public abstract void InstantiateObj(Vector3 targetPos);

    public void HandleObjectList(GameObject obj, int maxObjectCount = 6) {
        objects.Add(obj);
        if (objects.Count > maxObjectCount) {
            Destroy(objects[0]);
            objects.RemoveAt(0);
        }
    }
}
