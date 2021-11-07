using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFallingRockSpawner : EnemySpawnerBase {
    
    protected override void InitFields() {
        minSpawnLevel = GameDataManager.instance.enemyData.fallingRockMinLevel;
        spawnChance = GameDataManager.instance.enemyData.fallingRockSpawnChance;
    }

    public override void InstantiateObj(Vector3 targetPos) {
        var position = targetPos + new Vector3(Random.Range(-1.0f, 1.0f), 10, -0.5f);
        var obj = Instantiate(prefab, position, prefab.transform.rotation, transform);
        HandleObjectList(obj);
    }
}
