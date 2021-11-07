using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovingSawSpawner : EnemySpawnerBase {
    
    protected override void InitFields() {
        minSpawnLevel = GameDataManager.instance.enemyData.movingSawMinLevel;
        spawnChance = GameDataManager.instance.enemyData.movingSawSpawnChance;
    }

    public override void InstantiateObj(Vector3 targetPos) {
        var position = targetPos + new Vector3(0, Random.Range(1.2f, 1.7f), 0);
        var obj = Instantiate(prefab, position, prefab.transform.rotation, transform);
        HandleObjectList(obj);
    }
}
