using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
        print("Particles collided with" + gameObject.name);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
