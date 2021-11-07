using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFallingRockBehaviour : BaseMovingEnemyBehaviour {
    protected override void OnStart() {
        speed = GameDataManager.instance.enemyData.fallingRockSpeed;
    }

    protected override void Move() {
        transform.position += new Vector3(0,-1 * Time.deltaTime * speed, 0);
    }
}
