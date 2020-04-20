using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionHandle : MonoBehaviour
{
    [Tooltip("second")][SerializeField] float LoadLevelDelay = 1f;
    [SerializeField] GameObject deathFX;

   
    // Start is called before the first frame update
   
    private void OnTriggerEnter(Collider other) //elObject hyd5ol gwah  l haga
    {
     
        StartDeathSequence();
        deathFX.SetActive(true); //GameObject On
    }
    private void StartDeathSequence()
    {

       
        SendMessage("OnPlayerDeath"); //Calling Functions from another SCRIPT
        Invoke("ReloadLevel", LoadLevelDelay); 
        
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame

}
