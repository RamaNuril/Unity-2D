using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField]private float sceneLoadDelay = 2f;
    ScoreKeeper scoreKeeper;

    void Start() 
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();    
    }

    public void LoadGame()
    {
        scoreKeeper.ResetScore();
        SceneManager.LoadScene("Game");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad("GameOver", sceneLoadDelay));
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }

    IEnumerator WaitAndLoad(string scenename, float delay)
    {   
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(scenename);
    }
}
