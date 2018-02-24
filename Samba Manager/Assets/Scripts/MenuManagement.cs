using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

using UnityEngine.UI;
using UnityEngine;

public class MenuManagement : MonoBehaviour
{
    public Button coreografo, carnavalesco, ritimista, costureiro; //botões de seleção dos integrantes.
    public Dropdown cor1, carn1, rit1, cost1; //caixa de seleção para definir o estilo de cada integrante.
    public Slider cor2, carn2, rit2, cost2; // sliders usados para definir a influência de cada integrante.
    public Button cor3, carn3, rit3, cost3; //botões que servem para realizar upgrade em cada integrante (AINDA NÃO SEI DIREITO QUAL A FINALIDADE)
    public Text cor4,carn4,rit4,cost4; //caixas de testo que serão usados na descrição da função de cada integrante.
    public Button voltar,desfilar; //botões que ssão usados para troca de cena.
    //bool select = true;
    //bool activate = false;
   // public EventSystem current2;
    public Scene MenuPrototipo;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    public void CorSelAct()//método PRONTO E EXECUTANDO ADEQUADAMENTE
    {
        //uma vez selecionado o coreógrafo, ativa os botões de interação entre eles.
        cor1.gameObject.SetActive(true);
        cor2.gameObject.SetActive(true);
        cor3.gameObject.SetActive(true);
        
        //o comando abaixo, após selecionar o botão principal, pula para o Game Object selecionado entre parenteses.
       // current2.SetSelectedGameObject(cor1.gameObject);
    }

    public void CorSlider()
    {
     //   current2.SetSelectedGameObject(cor4.gameObject);
     

        Debug.Log("Valor do Slider" + cor2.value);
    }
   

    public void CorSelDeact()
    {
        //uma vez selecionado o coreógrafo, ativa os botões de interação entre eles.
        //if (activate == true )
        {
            
            cor1.gameObject.SetActive(false);
            cor2.gameObject.SetActive(false);
            cor3.gameObject.SetActive(false);
          //  select = true;
         //   activate = false;
            Debug.Log("Teste2");
        }
        

    }

    public void CorTextSet()
    {
        cor4.enabled=true;
    }
    public void CorTextDes()
    {
        cor4.enabled = false;
    }

    public void CarnSel()
    {
        //uma vez selecionado o coreógrafo, ativa os botões de interação entre eles.
        carn1.gameObject.SetActive(true);
        //cor1.gameObject.SetActive(true);
        carn2.gameObject.SetActive(true);
        carn3.gameObject.SetActive(true);
    }

    public void CarnSelDeac()
    {
        //uma vez selecionado o coreógrafo, ativa os botões de interação entre eles.
        carn1.gameObject.SetActive(false);
        //cor1.gameObject.SetActive(true);
        carn2.gameObject.SetActive(false);
        carn3.gameObject.SetActive(false);
    }
    public void CostSel()
    {
        //uma vez selecionado o coreógrafo, ativa os botões de interação entre eles.
        cost1.gameObject.SetActive(true);
        //cor1.gameObject.SetActive(true);
        cost2.gameObject.SetActive(true);
        cost3.gameObject.SetActive(true);
    }

    public void RitSel()
    {
        //uma vez selecionado o coreógrafo, ativa os botões de interação entre eles.
        rit1.gameObject.SetActive(true);
        //cor1.gameObject.SetActive(true);
        rit2.gameObject.SetActive(true);
        rit3.gameObject.SetActive(true);
    }

    public void Voltar()
    {
        SceneManager.LoadScene("MenuPrototipo");
    }
}
