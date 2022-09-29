using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [SerializeField] string playerTag;
    [SerializeField] float bounceForce;

    public Animator anim;
    public ParticleSystem bounceClouds;
    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == playerTag)
        {
            anim.SetTrigger("Bounce");
            bounceClouds.Play();
            Rigidbody otherRB = collision.rigidbody;

            otherRB.AddExplosionForce(bounceForce, collision.contacts[0].point, 5);
        }
    }
}
