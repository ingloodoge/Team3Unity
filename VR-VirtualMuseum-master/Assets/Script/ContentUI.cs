using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ContentUI : MonoBehaviour
{
    public TextMeshProUGUI nametext;
    public TextMeshProUGUI contenttext;
    public TextMeshProUGUI Btntext;
    
    
    public Button NextBtn;
    public List<string> contentList;
    private int contentIndex = 0;
    public PlayerMoveController playermoveController;

    private void Start()
    {
        hide();
    }
    public void show()
    {
        playermoveController.UIstate = true;
        Cursor.lockState = CursorLockMode.None;
        
        gameObject.SetActive(true);
    }

    public void show(string name,string[] content)
    {
        Btntext.text = "Confirm";
        nametext.text = name;
        contentList = new List<string>();
        contentList.AddRange(content);
        contentIndex = 0;
        contenttext.text = contentList[contentIndex];
        gameObject.SetActive(true);
        playermoveController.UIstate = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void hide()
    {
        playermoveController.UIstate = false;
        Cursor.lockState = CursorLockMode.Locked;
        gameObject.SetActive(false);
        
        
       
    }

    public void OnNextBtnClick()
    {
        
        contentIndex++;
        if (contentIndex == contentList.Count - 1)
        {
            Btntext.text = "Confirm";
        }
        else
        {
            Btntext.text = "Next";
        }
        if (contentIndex >= contentList.Count)
        {

            hide();
            return;
        }
        contenttext.text = contentList[contentIndex];

    }


}