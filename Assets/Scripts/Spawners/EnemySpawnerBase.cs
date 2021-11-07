using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemySpawnerBase : SpawnerBase {
    protected int minSpawnLevel;
    protected float spawnChance;

    protected abstract void InitFields();
    
    public abstract override void InstantiateObj(Vector3 targetPos);

    private void Start() {
        InitFields();
    }

    public int GetMinSpawnLevel() {
        return minSpawnLevel;
    }
    
    public float GetSpawnChance() {
        return spawnChance;
    }
}
