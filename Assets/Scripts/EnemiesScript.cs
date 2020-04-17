using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesScript : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    
    // Start is called before the first frame update
    void Start()
    {
        AddNonTriggerBoxCollider();

    }

    private  void AddNonTriggerBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;

        
    }

    private void OnParticleCollision(GameObject other) 
    {
         GameObject enemyClone = Instantiate(deathFX, transform.position, Quaternion.identity);
         enemyClone.transform.parent = parent; //By2olk el fx.mkano.el parent bt3o , hwa el GameObject ele aana 7ttholo f SerializeField
         Destroy(gameObject); 
        
    }

    // Update is called once per frame
}
