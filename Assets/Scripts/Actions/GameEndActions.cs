using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndActions : MonoBehaviour {
    public void PlayAgain() {
        MenuTransitionManager.instance.GameEndToGame();
    }

    public void Menu() {
        MenuTransitionManager.instance.GameEndToMenu();
    }
    
}
