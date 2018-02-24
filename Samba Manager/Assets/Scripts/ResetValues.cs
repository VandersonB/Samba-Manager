using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetValues : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetFloat("FantasiaCarna", 0);
        PlayerPrefs.SetFloat("Convidados", 0);
        PlayerPrefs.SetFloat("Carros", 0);

        PlayerPrefs.SetFloat("Comissao", 0);
        PlayerPrefs.SetFloat("VelhaGuarda", 0);
        PlayerPrefs.SetFloat("FantasiaCostura", 0);

        PlayerPrefs.SetFloat("SambaPe", 0);
        PlayerPrefs.SetFloat("Evolucao", 0);
        PlayerPrefs.SetFloat("Alas", 0);

        PlayerPrefs.SetFloat("Instrumentos", 0);
        PlayerPrefs.SetFloat("SambaEnredo", 0);
        PlayerPrefs.SetFloat("Ritmo", 0);

        PlayerPrefs.SetFloat("Pontuacao", 0);
    }
}
