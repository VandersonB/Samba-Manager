using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

    private bool audioOn = false;

	// Use this for initialization
	void Start () {
        Awake();
	}
	
	// Update is called once per frame
	void Update () {
	}

    void Awake()
    {
        Destroy(GameObject.Find("Audio Source"));
        GameObject.DontDestroyOnLoad(this.gameObject);
        
    }
}
