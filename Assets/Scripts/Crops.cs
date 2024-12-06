using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Crops : MonoBehaviour
{
    // Grow a tree before you die? 
    // keep that tree growing- let it sprout life and kill life
    // let it grow before it dies.

    float HealTime = 0.0f;
    bool startheal = false;

    
    public Renderer myRend;
    public Mesh myMesh;

    public Mesh fullyGrown;
    public Mesh hitOne;
    public Mesh hitTwo;
    public Mesh death; 

    // States
    public enum states
    {
        FULL, 
        MID,
        MID2,
        DEAD
    }
    public states state;
    private states prevstate;

    private void Start()
    {
        myMesh = GetComponent<Mesh>();
        state = states.FULL;
    }


    // Update is called once per frame
    void Update()
    {
        // SYSTEM STATE
        switch (state)
        {
            case states.FULL:
                myMesh = fullyGrown;
                break;

            case states.MID:
                prevstate = states.FULL;
                startheal = true;
                healstate();

                break;

            case states.MID2:
                prevstate = states.MID;
                startheal = true;
                healstate();

                break;

            case states.DEAD:
                prevstate = states.MID2;
                startheal = true;
                healstate();


                break;
                
        }
    }

    void healstate()
    {
        startheal = false;
        HealTime = 0.0f;
        if(HealTime == 10.00f && HealTime == 11.00f)
        {
            state = prevstate;
        }
    }

    private void FixedUpdate()
    {
        if(startheal == true){
            HealTime += Time.deltaTime;
        }

        Debug.Log(HealTime);
    }
}
