using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : SpawnerBase {
    public override void InstantiateObj(Vector3 targetPos) {
        var obj = Instantiate(prefab, targetPos, Random.rotation, transform);
        HandleObjectList(obj);
    }
}
