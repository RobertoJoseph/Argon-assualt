using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MusicPlayer : MonoBehaviour
    

{
    AudioSource audioSource;
    [SerializeField] float LoadLevelDelay = 1f;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

       
    }

    // Start is called before the first frame update

    void Start()
    {
      
        audioSource = GetComponent<AudioSource>();
        Invoke("LoadNextLevel", LoadLevelDelay);
        
       

        
    }

    // Update is called once per frame
   
    void Update()
    {
        
        
        
    }
    void LoadNextLevel()
    {
       
        SceneManager.LoadScene(1);
    }
}
