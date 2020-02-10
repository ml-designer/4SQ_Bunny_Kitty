using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivationTrigger : MonoBehaviour
{
    //Place on game object being shot (ie Food)
    [SerializeField] private GameObject displayed;

    //Active before collision
    void Start()
    {
        displayed.SetActive(true);
    }

    //When food collides with another object tagged "Person", the food is set false
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Person"))
        {
            displayed.SetActive(false);

        }
    }
}
