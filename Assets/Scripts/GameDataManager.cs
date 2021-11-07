using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour {
    public static GameDataManager instance;
    public EnemyData enemyData;
    private void Awake() {
        if (instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }
    }
}
