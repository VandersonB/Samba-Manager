using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValuesMath : MonoBehaviour {

    //variaveis do jogador
    float fantasia_carna;
    float convidados;
    float carros;

    float comissao;
    float velha_guarda;
    float fantasia_costura;

    float sambape;
    float evolucao;
    float alas;

    float instrumentos;
    float sambaEnredo;
    float ritmo;

    //variavel de pontuação total
    float pontosTotal;

    // Use this for initialization
    void Start () {

        GetAll_values();

        //pontosTotal = formula matematica de pontuacao final
        //atribuicao a pontuacao final
        // PlayerPrefs.SetFloat("Pontuacao", pontosTotal);

    }

    private void GetAll_values()
    {
        fantasia_carna = PlayerPrefs.GetFloat("FantasiaCarna");
        convidados = PlayerPrefs.GetFloat("Convidados");
        carros = PlayerPrefs.GetFloat("Carros");

        comissao = PlayerPrefs.GetFloat("Comissao");
        velha_guarda = PlayerPrefs.GetFloat("VelhaGuarda");
        fantasia_costura = PlayerPrefs.GetFloat("FantasiaCostura");

        sambape = PlayerPrefs.GetFloat("SambaPe");
        evolucao = PlayerPrefs.GetFloat("Evolucao");
        alas = PlayerPrefs.GetFloat("Alas");

        instrumentos = PlayerPrefs.GetFloat("Instrumentos");
        sambaEnredo = PlayerPrefs.GetFloat("SambaEnredo");
        ritmo = PlayerPrefs.GetFloat("Ritmo");
    }

}
