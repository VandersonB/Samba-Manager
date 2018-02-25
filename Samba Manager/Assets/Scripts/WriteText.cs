using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteText : MonoBehaviour {

    public float valorNota;

	// Use this for initialization
	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = valorNota.ToString("F1");
        this.transform.GetChild(0).GetComponent<Text>().text = valorNota.ToString("F1");
    }
}
