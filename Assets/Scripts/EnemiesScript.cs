using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesScript : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int ScorePerHit = 12;
    [SerializeField] float hits = 10f;
    ScoreBoard scoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        
        AddNonTriggerBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>(); // Initalize el scoreBoard de b ay object leha script esmo ScoreBoard 


    }

    private  void AddNonTriggerBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;

        
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
       

        if (hits <= 0)
        {
            KillEnemy();
        }




    }

    private void ProcessHit()
    {
        scoreBoard.ScoreHit(ScorePerHit);
        hits--;
    }

    private void KillEnemy()
    {
        GameObject enemyClone = Instantiate(deathFX, transform.position, Quaternion.identity);
        enemyClone.transform.parent = parent; //By2olk el enemyClone.mkano.el parent bt3o , hwa el GameObject ele aana 7ttholo f SerializeField
        Destroy(gameObject);
    }

    // Update is called once per frame
}
