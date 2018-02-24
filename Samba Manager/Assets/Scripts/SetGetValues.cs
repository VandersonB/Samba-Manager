using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetGetValues : MonoBehaviour {

    public Slider fantasia_carna;
    public Slider convidados;
    public Slider carros;

    public Slider comissao;
    public Slider velha_guarda;
    public Slider fantasia_costura;

    public Slider sambape;
    public Slider evolucao;
    public Slider alas;

    public Slider instrumentos;
    public Slider sambaEnredo;
    public Slider ritmo;

    public Text pontuacao;

    // Use this for initialization
    void Start () {
        Inic_sliders();
        pontuacao.text = PlayerPrefs.GetFloat("Pontuacao").ToString();
    }

    private void Inic_sliders()
    {
        //inicializacao dos sliders
        fantasia_carna.value = PlayerPrefs.GetFloat("FantasiaCarna");
        convidados.value = PlayerPrefs.GetFloat("Convidados");
        carros.value = PlayerPrefs.GetFloat("Carros");

        comissao.value = PlayerPrefs.GetFloat("Comissao");
        velha_guarda.value = PlayerPrefs.GetFloat("VelhaGuarda");
        fantasia_costura.value = PlayerPrefs.GetFloat("FantasiaCostura");

        sambape.value = PlayerPrefs.GetFloat("SambaPe");
        evolucao.value = PlayerPrefs.GetFloat("Evolucao");
        alas.value = PlayerPrefs.GetFloat("Alas");

        instrumentos.value = PlayerPrefs.GetFloat("Instrumentos");
        sambaEnredo.value = PlayerPrefs.GetFloat("SambaEnredo");
        ritmo.value = PlayerPrefs.GetFloat("Ritmo");        
    }

    // Update is called once per frame
    void Update () {
        Set_var_player();
    }

    private void Set_var_player()
    {
        //Set das variaveis
        PlayerPrefs.SetFloat("FantasiaCarna", fantasia_carna.value);
        PlayerPrefs.SetFloat("Convidados", convidados.value);
        PlayerPrefs.SetFloat("Carros", carros.value);

        PlayerPrefs.SetFloat("Comissao", comissao.value);
        PlayerPrefs.SetFloat("VelhaGuarda", velha_guarda.value);
        PlayerPrefs.SetFloat("FantasiaCostura", fantasia_costura.value);

        PlayerPrefs.SetFloat("SambaPe", sambape.value);
        PlayerPrefs.SetFloat("Evolucao", evolucao.value);
        PlayerPrefs.SetFloat("Alas", alas.value);

        PlayerPrefs.SetFloat("Instrumentos", instrumentos.value);
        PlayerPrefs.SetFloat("SambaEnredo", sambaEnredo.value);
        PlayerPrefs.SetFloat("Ritmo", ritmo.value);
    }
}
