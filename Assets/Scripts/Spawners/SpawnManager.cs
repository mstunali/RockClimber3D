using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public static SpawnManager instance;
    public EnemySpawnerBase[] enemySpawners;
    public RockSpawner rockSpawner;
    public TargetSideRocksSpawner sideRocksSpawner;

    private void Awake() {
        if (instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }
    }
    
    public void SpawnRock(Vector3 targetPos) {
        rockSpawner.InstantiateObj(targetPos);
    }
    
    public void SpawnSideRocks(Vector3 targetPos) {
        sideRocksSpawner.InstantiateObj(targetPos);
    }

    public void SpawnEnemy(Vector3 targetPos, int playerLevel) {
        var availableSpawners = enemySpawners.Where(c => c.GetMinSpawnLevel() < playerLevel ).ToArray();
        if (availableSpawners.Length <= 0) return;
        var spawnerIndex = Random.Range(0, availableSpawners.Length);
        var spawnChance = Random.Range(0, 1.0f);
        if (availableSpawners[spawnerIndex].GetSpawnChance() > spawnChance) {
            availableSpawners[spawnerIndex].InstantiateObj(targetPos);
        }
    }
}
