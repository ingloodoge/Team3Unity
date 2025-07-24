using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITips : MonoBehaviour
{
    
    public TextMeshProUGUI Tipstext;


    private void Start()
    {
        hide();
        Tipstext.text = "Press [F] to check object";
    }
    public void show()
    {

       
        gameObject.SetActive(true);
    }

    public void hide()
    {
        gameObject.SetActive(false);
    }
}
