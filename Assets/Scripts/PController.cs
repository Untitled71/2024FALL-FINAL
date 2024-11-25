using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PController : MonoBehaviour
{
    // PLAYER INPUT MANAGEMENT
    public Camera myCam;
    Vector3 inputDir;

    public enum pStates
    {
        GROUNDED,
        INAIR
    }
    public pStates state;

    public bool jump;

    private float moveInput;
    private float turnInput;

    private void InputManagement()
    {
        moveInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }


    // PLAYER STAT VARIABLES
    public float health;
    public float speed; 
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputManagement();
        if(Input.GetKeyDown(KeyCode.Space)) { jump = true; }
    }

    private void FixedUpdate()
    {
        // SYSTEM STATE
        switch (state)
        {
            case pStates.GROUNDED:

                break;

            case pStates.INAIR:

                break;
        }
    }



}
