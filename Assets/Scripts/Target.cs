using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject cube;

    public AudioSource audioSource;
    
    void Start()
    {
        // audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GolfClub"))
        {
            Debug.Log("Collision");
            Explode();
        }
    }

    void Explode()
    {
        gameObject.SetActive(false);
        audioSource.Play();
    }
}
