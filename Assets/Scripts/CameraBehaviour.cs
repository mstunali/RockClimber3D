using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {
    public GameObject player;

    private void LateUpdate() {
        transform.position = player.transform.position + new Vector3(0,1,-7.5f);
    }
}
