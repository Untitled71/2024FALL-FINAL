using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PController : MonoBehaviour
{
    Rigidbody PlayerRb;
    public Camera myCam;
    Vector3 inputDir;

    // EXTERNAL OBJECTS~
    public GameObject bulletPrefab;
    public Transform firingPoint;

    // MOVEMENT VAR
    protected float speed = 10.0f;
    public float jump = 3.0f;
    public bool inair = false;
    public bool doublejumped = false;

    // PLAYER STATS
    public int Score = 0;
    public float Health = 3.0f;
    public float Mana = 10.0f;
    public float damage = 1.0f;


    // States
    public enum Playerstates
    {
        ALIVE, 
        LIMINAL,
        GHOST, 
        DEAD
    }
    public Playerstates state;
    private Playerstates prevstate;


    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        state = Playerstates.ALIVE;
    }


    void Update()
    {
        // SYSTEM STATE
        switch (state)
        {
            case Playerstates.ALIVE:

                break;

            case Playerstates.LIMINAL:

                break;

            case Playerstates.GHOST:


                break;

            case Playerstates.DEAD:


                break;
        }
    }





    private void FixedUpdate()
    {
        // Movement
        PlayerRb.AddForce(transform.TransformDirection(PlayerDir()).normalized * speed);
    }

    Vector3 PlayerDir()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 pDir = new Vector3(x, 0, z);

        return pDir;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            inair = false;
            doublejumped = false;
            //Debug.Log("on Ground");
        }
        if (collision.gameObject.tag == "enemy")
        {
            //Health -= collision.gameObject.GetComponent<Enemies>().dmgdealt;
            Score--;
            Debug.Log(Health);
        }
    }
}


