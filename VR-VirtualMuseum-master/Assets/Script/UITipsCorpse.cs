using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITipsCorpse : MonoBehaviour
{
    public TextMeshProUGUI Tipstext;


    private void Start()
    {
        hide();
        Tipstext.text = "Press [E] to check";
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
