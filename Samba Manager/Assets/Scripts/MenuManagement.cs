using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MenuManagement : MonoBehaviour
{
    public Button coreografo, canavalesco, ritimista, costureiro; //botões de seleção dos integrantes.
    public Dropdown cor1, carn1, rit1, cost1; //caixa de seleção para definir o estilo de cada integrante.
    public Slider cor2, carn2, rit2, cost2; // sliders usados para definir a influência de cada integrante.
    public Button cor3, carn3, rit3, cost3; //botões que servem para realizar upgrade em cada integrante (AINDA NÃO SEI DIREITO QUAL A FINALIDADE)
    public Text cor4,carn4,rit4,cost4; //caixas de testo que serão usados na descrição da função de cada integrante.
    public Button voltar,desfilar; //botões que ssão usados para troca de cena.


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void CorSel()
    {
        //uma vez selecionado o coreógrafo, ativa os botões de interação entre eles.
        cor1.gameObject.SetActive(true);
        cor1.gameObject.SetActive(true);
        cor2.gameObject.SetActive(true);
        cor3.gameObject.SetActive(true); 
    }
}
