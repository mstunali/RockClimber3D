using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSideRocksSpawner : SpawnerBase {
    public override void InstantiateObj(Vector3 targetPos) {
        var obj = Instantiate(prefab, targetPos + new Vector3(4.0f,0,0.5f), Quaternion.Euler(0,Random.Range(0,360),0), transform);
        HandleObjectList(obj,9);
        obj = Instantiate(prefab, targetPos + new Vector3(-4.0f,0,0.5f), Quaternion.Euler(0,Random.Range(0,360),0), transform);
        HandleObjectList(obj,9);
    }
}
