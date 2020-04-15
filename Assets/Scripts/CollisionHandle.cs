using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionHandle : MonoBehaviour
{
    [Tooltip("second")][SerializeField] float LoadLevelDelay = 1f;
    [SerializeField] GameObject deathFX;

   
    // Start is called before the first frame update
   
    private void OnTriggerEnter(Collider other)
    {
     
        StartDeathSequence();
        deathFX.SetActive(true);
    }
    private void StartDeathSequence()
    {

        print("Player Dying");
        SendMessage("OnPlayerDeath");
        Invoke("ReloadLevel", LoadLevelDelay);
        
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame

}
