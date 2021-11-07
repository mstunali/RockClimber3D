using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    private float speed = 4;
    private Vector3 targetPos;

    private void Start() {
        targetPos = transform.position;
    }

    void LateUpdate() {
        float difX = transform.position.x - targetPos.x;
        if (difX < 0.001f && difX > -0.001f) {
            transform.position = targetPos;
        }
        else {
            transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);
        }
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (hit.transform.tag == "rock") {
                    targetPos = new Vector3(hit.transform.position.x, hit.transform.position.y, 0);
                    GameManager.instance.NextTarget();
                }
            }
        }
    }

}
