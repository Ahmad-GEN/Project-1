using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowAnimal : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator anim;
    public GameObject animal;

    private void Start()
    {
        anim.SetBool("idle", true);
    }

    private void Update()
    {
        FollowThePlayer();
    }

    public void FollowThePlayer()
    {
        if (animal == null) return;

        agent.SetDestination(animal.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pick up"))
        {
            animal = other.gameObject;
            anim.SetBool("idle", false);
            anim.SetBool("walk", true);
        }
    }
}
