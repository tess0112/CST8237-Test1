using UnityEngine;

[RequireComponent(typeof(Light))]
public class Alarm : MonoBehaviour {
    GameObject ball;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        ball = GameObject.Find("Sphere");
        audioSource = new AudioSource();
        audioSource = GetComponent<AudioSource>();
    }

    // Based on Lab5 OnTriggerEnter
    public void OnTriggerEnter(Collider collider)
    {
        audioSource.Play();
        ball.transform.localPosition = new Vector3(-3.5f, 1, 3.5f);
    }
}
