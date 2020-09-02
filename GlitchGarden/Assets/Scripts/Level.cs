using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float timeBetweenScenes = 3f;
    int currentScene;



    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene == 0)
        {
            StartCoroutine(LoadStartScene());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadStartScene()
    {
  
        yield return new WaitForSeconds(timeBetweenScenes);
        SceneManager.LoadScene(1);
        
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentScene);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
        
    }

    public void LoadOptionsMenu()
    {
       
        SceneManager.LoadScene("Options Screen");

    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScene + 1);
    }

    public void LoadYouLose()
    {
        SceneManager.LoadScene("Lose Screen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
