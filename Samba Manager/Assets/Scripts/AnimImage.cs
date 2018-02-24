using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class AnimImage : MonoBehaviour
{

    public Image carn, coreo, cost, rit;
    public Text carnText, coreoText, ritText, costText;
    Vector3 size;
    
	// Use this for initialization
	void Start ()
    {
        Cursor.visible = true;
        size = carn.GetComponent<Transform>().localScale;
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {

    }

    public void AnimImCarn()
    {
            carn.GetComponent<Animator>().enabled = true;
            carnText.enabled = true;

    }

    public void AnimImCarnIna()
    {
        carn.GetComponent<Animator>().enabled = false;
        carnText.enabled = false;
        carn.GetComponent<Transform>().localScale = size;
    }

    public void AnimImCost()
    {
        cost.GetComponent<Animator>().enabled = true;
        costText.enabled = true;

    }

    public void AnimImCostIna()
    {
        cost.GetComponent<Animator>().enabled = false;
        costText.enabled = false;
        cost.GetComponent<Transform>().localScale = size;
    }

    public void AnimImCoreo()
    {
        coreo.GetComponent<Animator>().enabled = true;
        coreoText.enabled = true;

    }

    public void AnimImCoreoIna()
    {
        coreo.GetComponent<Animator>().enabled = false;
        coreoText.enabled = false;
        coreo.GetComponent<Transform>().localScale = size;
    }
    public void AnimImRit()
    {
        rit.GetComponent<Animator>().enabled = true;
        ritText.enabled = true;

    }

    public void AnimImRitIna()
    {
        rit.GetComponent<Animator>().enabled = false;
        ritText.enabled = false;
        rit.GetComponent<Transform>().localScale = size;
    }
}
