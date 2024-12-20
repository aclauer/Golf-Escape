using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_golf_door_opener : MonoBehaviour
{
    public GameObject player;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePosition = player.transform.position - transform.position;

        if (relativePosition.magnitude < 3.0)
        {
            animator.SetBool("character_nearby", true);
        } else
        {
            animator.SetBool("character_nearby", false);
        }  
    }
}
