using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFood : MonoBehaviour
{
    //Projectile is food
    public GameObject projectile;
    //Camera must be attached to player
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Left mouse button pressed to activate
        if (Input.GetButtonDown("Fire1"))
        {
            //projectile is set active after destruction from DeactivationTrigger.cs
            projectile.SetActive(true);
            //Distance from player object (in this case it is shooting from in front of player camera)
            projectile.transform.position = transform.position + cam.transform.forward * 2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();

            //Speed of food is changed here
            rb.velocity = cam.transform.forward * 10;


        }
    }


}
