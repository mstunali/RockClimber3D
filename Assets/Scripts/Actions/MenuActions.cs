using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActions : MonoBehaviour {
    public void ToGame() {
        MenuTransitionManager.instance.MenuToGame();
    }
    
    public void Quit() {
        Application.Quit();
    }
}
