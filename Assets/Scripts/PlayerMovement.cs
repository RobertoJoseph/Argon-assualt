using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMovement : MonoBehaviour
{
    [Header("General")]

    [Tooltip("In m*s^-1")] [SerializeField] float controlSpeed = 90;
    [Tooltip(" In m")] [SerializeField] float xRange = 140f;
    [Tooltip(" In m")] [SerializeField] float yRange = 70f;
    [SerializeField] GameObject[] guns;

    [Header("Screen-Position Based")]

    [SerializeField] float PositionPitchFactor = -0.242f;
    [SerializeField] float PositionYawFactor = 0.4f;

    [Header("Control-Position Based")]

    [SerializeField] float ControlPitchFactor = -20f;
    [SerializeField] float ControlRollFactor = -20f;

    float xThrow;
    float yThrow;
    bool isControlsEnabled = true;
   



    // Start is called before the first frame update
    void Start()
    {
       
       
    }



    // Update is called once per frame
    void Update()
    {
        if (isControlsEnabled)
        {

        
        ProcessMovement();
        ProcessRotation();
        ProcessFiring();
    }

}
   void OnPlayerDeath()
    {
        isControlsEnabled = false;
        
    }
    private void ProcessMovement()
    {

         xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
         yThrow = CrossPlatformInputManager.GetAxis("Vertical");

        float xOffset = xThrow * controlSpeed * Time.deltaTime; //How much the object moves in this frame , as msln l value of xThrow = -1*5m/s*1s = -1*5=5m hyt7rk 5 GAMD 
        float yOffset = yThrow * controlSpeed * Time.deltaTime;

        float rawNewXPos = transform.localPosition.x + xOffset;
        float rawNewyPos = transform.localPosition.y + yOffset;

        float clampXPost = Mathf.Clamp(rawNewXPos, -xRange, xRange); //bt5ly el ship tt7rk f range mn kza l kza
        float clampYPost = Mathf.Clamp(rawNewyPos, -yRange, yRange);


        transform.localPosition = new Vector3(clampXPost, clampYPost, transform.localPosition.z);
    }

    private void ProcessRotation()
    {
        float pitchDueToPosition = transform.localPosition.y * PositionPitchFactor;
        float pitchDueToControl = yThrow * ControlPitchFactor;
        float pitch = pitchDueToPosition + pitchDueToControl;  

        float yawDueToPosition= transform.localPosition.x * PositionYawFactor;
        float yaw = yawDueToPosition;

        float rollDueToControl = xThrow * ControlRollFactor;
        float roll = rollDueToControl;
        transform.localRotation = Quaternion.Euler(pitch, yaw, roll); // (Pitch , Yaw , Roll)
    }
    void ProcessFiring()
    {
        if (CrossPlatformInputManager.GetButton("Fire"))
        {

            SetGunsActive(true);
        }
        else
        {
            SetGunsActive(false);
        }

    }
    void SetGunsActive(bool isActive)
    {
        foreach(GameObject gun in guns) //el gun el awl feha Bullet 1 , f tro7 3mlha activate w b3d kda l gun tany feha bullet 2 , tro7 3mlhla activate tany
        {
            var emissionSystem = gun.GetComponent<ParticleSystem>().emission; //Bt acess el emission setting ele mawgoda f particle 
            emissionSystem.enabled = isActive;
        }
    }
   
    


}
