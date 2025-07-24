using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsItems : MonoBehaviour
{
    public string name;
    public float distmin;
    public int minflag;//��¼��ǰ��������Ľ�ɫ���
    public GameObject playerPosition;
    private GameObject minTest;
    public List<GameObject> items;
    public UITips UITips;
    public bool F=false;
    public ContentUI ContentUI;
    public string[] contentList;
    private Information Information;
    public UIPick UIPick;
    public bool photo=false;
    public bool knife=false;

    public bool pillien = false;

    void Start()
    {
        photo = false;
        knife = false;
        pillien = false;
    }

    // Update is called once per frame
    void Update()
    {
        distmin = 10;
        for (int i = 0; i < items.Count; i++)
        {
            float dist = Vector3.Distance(playerPosition.transform.position, items[i].transform.position);
            if (dist < distmin)
            {
                distmin = dist;
                minflag = i;
            }
        }
        minTest = items[minflag];
        Information=minTest.GetComponent<Information>();
        


        if (distmin < 2)
        {
            if (F == false)
            {
                UITips.show();
                if (Input.GetKeyDown(KeyCode.F))
                {
                    if (minTest.tag == "photo")
                    {
                        photo = true;
                    }
                    if (minTest.tag == "knife")
                    {
                        knife = true;
                    }
                    if (minTest.tag == "pillien")
                    {
                        pillien = true;
                    }
                    print(photo);
                    print(knife);
                    print(pillien);
                    UITips.hide();
                    ContentUI.show(Information.Name,Information.Content);
                    if (Information.pickup == false)
                    {
                        UIPick.show(Information.Pickuptips);
                        Information.pickup=true;
                    }
                    
                         

                    F = true;
                }
            }
            
        }
        if (distmin >=2 )
        {
            F= false;
            UITips.hide();
           
        }


    }
}
