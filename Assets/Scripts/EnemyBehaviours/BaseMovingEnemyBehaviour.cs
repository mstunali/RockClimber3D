using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMovingEnemyBehaviour : BaseEnemyBehaviour {
    protected float speed;

    protected abstract void OnStart();
    protected abstract void Move();
    
    void Start() {
        OnStart();
    }

    void Update() {
        Move();
    }
}
