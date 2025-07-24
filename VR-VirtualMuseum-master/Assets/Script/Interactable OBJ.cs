using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class interactableOBJ : MonoBehaviour
{
    public string name;
    public string[] contentList;
    public ContentUI contentUI;
    public UIPick UIPick;
    public void onclick()
    {
     
        pickClick();
    }

    public void pickClick()
    {
        contentUI.show(name, contentList);
        UIPick.show(name);
        
    }
            
            


       
        




        
}
