using UnityEngine;
using System.Collections;

public class RollingSound : MonoBehaviour {
    Rigidbody _rigidbody;
    int _collisionCount = 0;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        audioSource = new AudioSource();
        audioSource = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update () {
    if(_collisionCount > 0) {
      if(audioSource.isPlaying == false) {
        audioSource.Play();
      }

      float volume = Mathf.Clamp(_rigidbody.velocity.magnitude, 0.0f, 1.0f);
      // set volume.

      audioSource.volume = volume;
    }
    else {
      if(audioSource.isPlaying) {
        audioSource.Stop();
      }
    }
  }

  public void OnCollisionEnter() {
    _collisionCount++;
  }

  public void OnCollisionExit() {
    _collisionCount--;
  }

}
