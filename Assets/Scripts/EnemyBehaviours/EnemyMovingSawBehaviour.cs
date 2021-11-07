using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EnemyMovingSawBehaviour : BaseMovingEnemyBehaviour {
    private Vector3 startPos;

    protected override void OnStart() {
        speed = GameDataManager.instance.enemyData.movingSawSpeed;
        startPos = transform.position;
    }

    protected override void Move() {
        transform.position = startPos + new Vector3(2 * Mathf.Sin(Time.time * speed),0, 0);
    }

}
