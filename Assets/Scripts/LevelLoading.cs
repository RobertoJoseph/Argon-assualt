using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{
    [SerializeField] float LoadLevelDelay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadNextLevel", LoadLevelDelay);
        
    }

    // Update is called once per frame
   
    void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
