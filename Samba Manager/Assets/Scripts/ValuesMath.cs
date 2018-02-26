using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValuesMath : MonoBehaviour {

    //variaveis do jogador
    float fantasia_carna, fantasia_carna_norm;
    float convidados, convidados_norm;
    float carros, carros_norm;

    float comissao, comissao_norm;
    float velha_guarda, velha_guarda_norm;
    float fantasia_costura, fantasia_costura_norm;

    float sambape, sambape_norm;
    float evolucao, evolucao_norm;
    float alas, alas_norm;

    float instrumentos, instrumentos_norm;
    float sambaEnredo, sambaEnredo_norm;
    float ritmo, ritmo_norm;

    //variavel de pontuação total
    public float nota_evolucao, nota_bateria, nota_enredo;
    public float nota_sambaEnredo, nota_fantasia, nota_comissaoDeFrente;
    public float nota_alegoria, nota_harmonia, nota_mestreSala;
    public float notaFinal;

    float notaminima = 8.5f;
    float fatornota = 0.15f;

    public WriteText script;

    // Use this for initialization
    void Start () {

        GetAll_values();
        Normalize_Values();
        Calculate();
        WriteOnObjects();

        //pontosTotal = formula matematica de pontuacao final
        //atribuicao a pontuacao final
        PlayerPrefs.SetFloat("Pontuacao", notaFinal);

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

    private void Normalize_Values()
    {
        float aux = fantasia_carna + convidados + carros;
        fantasia_carna_norm = fantasia_carna / aux;
        convidados_norm = convidados / aux;
        carros_norm = carros / aux;

        aux = comissao + velha_guarda + fantasia_costura;
        comissao_norm = comissao / aux;
        velha_guarda_norm = velha_guarda / aux;
        fantasia_costura_norm = fantasia_costura / aux;

        aux = sambape + evolucao + alas;
        sambape_norm = sambape / aux;
        evolucao_norm = evolucao / aux;
        alas_norm = alas / aux;

        aux = instrumentos + sambaEnredo + ritmo;
        instrumentos_norm = instrumentos / aux;
        sambaEnredo_norm = sambaEnredo / aux;
        ritmo_norm = ritmo / aux;
        
    }

    private void Calculate()
    {
        //Proporções
        nota_evolucao = (fantasia_carna_norm * 5 + convidados_norm * 5 + alas_norm * 12 + evolucao_norm * 18) / 4;
        nota_bateria = (ritmo_norm * 14 + instrumentos_norm * 6) / 2;
        nota_enredo = (sambaEnredo_norm * 19 + fantasia_costura_norm * 1) / 2;
        nota_sambaEnredo = (sambaEnredo_norm * 18 + velha_guarda_norm * 2) / 2;
        nota_fantasia = (carros_norm * 15 + convidados_norm * 5) / 2;
        nota_comissaoDeFrente = (comissao_norm * 15 + sambape_norm * 5) / 2;
        nota_alegoria = (fantasia_costura_norm * 8 + alas_norm * 2 + carros_norm * 20) / 3;
        nota_harmonia = (fantasia_carna_norm * 15 + ritmo_norm * 8 + velha_guarda_norm * 2 + evolucao_norm * 15) / 4;
        nota_mestreSala = (instrumentos_norm * 4 + comissao_norm * 1 + sambape_norm * 25) / 3;
        
        //Conversão em nota apresentavel
        nota_evolucao = Mathf.Round((notaminima + nota_evolucao * fatornota)*10)/10;
        nota_bateria = Mathf.Round((notaminima + nota_bateria * fatornota) * 10) / 10;
        nota_enredo = Mathf.Round((notaminima + nota_enredo * fatornota)*10)/ 10;
        nota_sambaEnredo = Mathf.Round((notaminima + nota_sambaEnredo * fatornota)*10)/ 10;
        nota_fantasia = Mathf.Round((notaminima + nota_fantasia * fatornota)*10)/ 10;
        nota_comissaoDeFrente = Mathf.Round((notaminima + nota_comissaoDeFrente * fatornota)*10)/ 10;
        nota_alegoria = Mathf.Round((notaminima + nota_alegoria * fatornota)*10)/ 10;
        nota_harmonia = Mathf.Round((notaminima + nota_harmonia * fatornota)*10)/ 10;
        nota_mestreSala = Mathf.Round((notaminima + nota_mestreSala * fatornota)*10)/ 10;

        notaFinal = Mathf.Round(((nota_evolucao + nota_bateria + nota_enredo + nota_sambaEnredo + nota_fantasia + nota_comissaoDeFrente + nota_alegoria + nota_harmonia + nota_mestreSala) / 9)*10)/ 10;

        //Elemento Aleatório

    }

    void WriteOnObjects()
    {
        script = GameObject.Find("nota_Evolucao").GetComponent<WriteText>();
        script.valorNota = nota_evolucao;

        script = GameObject.Find("nota_Bateria").GetComponent<WriteText>();
        script.valorNota = nota_bateria;

        script = GameObject.Find("nota_Enredo").GetComponent<WriteText>();
        script.valorNota = nota_enredo;

        script = GameObject.Find("nota_sambaEnredo").GetComponent<WriteText>();
        script.valorNota = nota_sambaEnredo;

        script = GameObject.Find("nota_Fantasia").GetComponent<WriteText>();
        script.valorNota = nota_fantasia;

        script = GameObject.Find("nota_ComissaoFrente").GetComponent<WriteText>();
        script.valorNota = nota_comissaoDeFrente;

        script = GameObject.Find("nota_Alegoria").GetComponent<WriteText>();
        script.valorNota = nota_alegoria;

        script = GameObject.Find("nota_Harmonia").GetComponent<WriteText>();
        script.valorNota = nota_harmonia;

        script = GameObject.Find("nota_MestreSala").GetComponent<WriteText>();
        script.valorNota = nota_mestreSala;

        script = GameObject.Find("nota_Final").GetComponent<WriteText>();
        script.valorNota = notaFinal;


    }

}
