using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    public Button jogar, creditos;
    public Scene MenuManager;
    public Scene Creditos;
    //public string teste;

	// Use this for initialization
	void Start ()
    {
        jogar.onClick = new Button.ButtonClickedEvent();
        creditos.onClick = new Button.ButtonClickedEvent();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Cred()
    {
        SceneManager.LoadScene("Creditos");
        Debug.Log("Botão de credito apertado");
    }

    public void Manager()
    {
        SceneManager.LoadScene("MenuManager");
        Debug.Log("Botão de jogar apertado");
    }

   
}
