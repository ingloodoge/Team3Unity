using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPick : MonoBehaviour
{
    public TextMeshProUGUI nametext;
    
    private void Start()
    {
        hide();
    }

    public void show(string PickUpTips)
    {
        nametext.text = PickUpTips;
        gameObject.SetActive(true);
        StartCoroutine(showtips());
    }
    public void hide()
    {
       
        gameObject.SetActive(false);
    }

    IEnumerator showtips()
    {

        yield return new WaitForSeconds(7);
        gameObject.SetActive(false);
    }
}
