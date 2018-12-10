using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class SwitchSnapshot : MonoBehaviour {

	[SerializeField] private AudioMixerSnapshot outside;
	[SerializeField] private AudioMixerSnapshot inside;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			inside.TransitionTo(0.1f);
            print("Player enters the zone");
		}
	}

	private void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			outside.TransitionTo(0.1f);
            print("Player leavess the zone");

        }
    }
}
