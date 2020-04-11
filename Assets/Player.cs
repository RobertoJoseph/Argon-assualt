using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Player : MonoBehaviour
{
    [Tooltip("In m*s^-1")] [SerializeField] float Speed = 90f;
    [Tooltip(" In m")] [SerializeField] float xRange = 140f;
    [Tooltip(" In m")] [SerializeField] float yRange = 70f;



    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * Speed * Time.deltaTime;
        float rawNewXPos = transform.localPosition.x + xOffset;
        float clampXPost = Mathf.Clamp(rawNewXPos, -xRange, xRange); //bt5ly el ship tt7rk f range mn kza l kza
      
        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = yThrow * Speed * Time.deltaTime;
        float rawNewyPos = transform.localPosition.y + yOffset;
        float clampYPost = Mathf.Clamp(rawNewyPos, -yRange, yRange);
        transform.localPosition = new Vector3(clampXPost, clampYPost, transform.localPosition.z);
















    }
}
