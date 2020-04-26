using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesScript : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int ScorePerHit = 12;
    [SerializeField] float hits = 10f;
    ScoreBoard scoreBoard; //3amla zy GameObject obj  w b3d kda bt2ol en l obj da hwa el object ele mn no3 msln ele enta t7ddo 
    // Start is called before the first frame update
    void Start()
    {
        
        AddNonTriggerBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>(); // Bt2olo dawrly 3la el object ele no3o ScoreBoard  , w hwa  Text !!


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
        GameObject enemyClone = Instantiate(deathFX, transform.position, Quaternion.identity); //Quatertnion identity means  no rotation around Z -Axis
        enemyClone.transform.parent = parent; //By2olk el enemyClone.mkano.el parent bt3o , hwa el GameObject ele aana 7ttholo f SerializeField
        Destroy(gameObject);
    }

    // Update is called once per frame
}
