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
