using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTransitionManager : MonoBehaviour {
    public static MenuTransitionManager instance;
    
    private void Awake() {
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(this);
        }else{
            Destroy(gameObject);
        }
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuToGame() {
        StartCoroutine(SceneSwitch("Menu", "Game"));
    }
    
    public void GameToGameEnd() {
        StartCoroutine(SceneSwitch("Game", "GameEnd"));
    }
    
    public void GameEndToGame() {
        StartCoroutine(SceneSwitch("GameEnd", "Game"));
    }
    
    public void GameEndToMenu() {
        StartCoroutine(SceneSwitch("GameEnd", "Menu"));
    }

    IEnumerator SceneSwitch(string from, string to)
    {
        AsyncOperation load = SceneManager.UnloadSceneAsync(from);
        yield return load;
        SceneManager.LoadSceneAsync(to, LoadSceneMode.Single);
    }
}
