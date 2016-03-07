using UnityEngine;
using System.Collections;

public class WallSound : MonoBehaviour {
    GameObject ball;
    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        ball = GameObject.Find("Sphere");
        audioSource = new AudioSource();
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Based on Lab5 OnCollisionEnter
        if (collision.collider.gameObject == ball)
        {
            audioSource.Play();
        }
    }
}
