using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemyBehaviour : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        if (other.transform.tag == "player") {
            MenuTransitionManager.instance.GameToGameEnd();
        }
    }

}
