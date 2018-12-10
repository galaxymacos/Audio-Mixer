using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class ActivateChannel : MonoBehaviour {

	[SerializeField] private AudioMixer audioM;

	[SerializeField] private string nameParam;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			audioM.SetFloat(nameParam, 0f);
		}
	}

	private void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			audioM.SetFloat(nameParam, -80f);
		}
	}
}
