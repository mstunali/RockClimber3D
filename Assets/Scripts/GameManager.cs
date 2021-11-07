using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    private int playerLevel = 0;
    private Vector3 currentTargetPos = new Vector3(0, 0, 0.3f);
    
    private void Awake() {
        if (instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }
    }

    private void Start() {
        SpawnManager.instance.SpawnRock(currentTargetPos);
        SpawnManager.instance.SpawnSideRocks(currentTargetPos);
        NextTarget();
        NextTarget();
    }
    
    

    public void NextTarget() {
        playerLevel++;
        CalculateTargetPos();
        SpawnManager.instance.SpawnRock(currentTargetPos);
        SpawnManager.instance.SpawnEnemy(currentTargetPos, playerLevel);
        SpawnManager.instance.SpawnSideRocks(currentTargetPos);
    }

    private void CalculateTargetPos() {
        // for not too close to previous target
        var x = Random.Range(1.5f, 2.0f);
        var direction = Random.Range(0, 2) == 0 ? -1 : 1;
        currentTargetPos += new Vector3(direction * x, Random.Range(3.0f, 4.0f), 0);
    }
}
