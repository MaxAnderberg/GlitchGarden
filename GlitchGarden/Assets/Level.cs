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
}
