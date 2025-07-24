using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class playerClick : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);//���������һ������
            RaycastHit hit;//�������������������Ϣ
            bool iscollider = Physics.Raycast(ray, out hit);//�ж��Ƿ���������
            if (iscollider && EventSystem.current.IsPointerOverGameObject() == false)
            {
                float dist = Vector3.Distance(hit.transform.position, transform.position);
                if (dist <= 2)
                {
                    if (hit.collider.tag == "interactable")
                    {
                        hit.collider.GetComponent<interactableOBJ>().onclick();
                        //����������NPC�����NPC���ϵ�onclick����
                    }
                    if (hit.collider.tag == "pickItems")
                    {
                        hit.collider.GetComponent<interactableOBJ>().pickClick();
                        //����������NPC�����NPC���ϵ�onclick����
                    }
                }
                

            }

        }
    }
}
