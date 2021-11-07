using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Data", menuName = "Enemy Data")]
public class EnemyData : ScriptableObject {
    public float movingSawSpeed;
    public int movingSawMinLevel;
    public float movingSawSpawnChance;
    public float fallingRockSpeed;
    public int fallingRockMinLevel;
    public float fallingRockSpawnChance;
}
