using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Goal : MonoBehaviour {
    GameObject ball;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
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
            StartCoroutine(WaitForGoalSound());
        }
    }

    IEnumerator WaitForGoalSound()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("MenuScene");
    }
}
