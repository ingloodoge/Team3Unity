using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Characters : MonoBehaviour
{
    public List<GameObject> CharacterList;
    public CG videoCG;
    public float distmin;
    public int minflag;
    public GameObject playerPosition;
    private GameObject minTest;
    private CharacterInformation CInfo;
    public UITipsCorpse UITipsCorpse;
    public bool Character1=false;
    public bool Character2=false;
    public bool Character3=false;


    void Start()
    {
        Character1 = false;
        Character2 = false;
        Character3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        distmin = 10;
        for (int i = 0; i < CharacterList.Count; i++)
        {
            float dist = Vector3.Distance(playerPosition.transform.position, CharacterList[i].transform.position);
            if (dist < distmin)
            {
                distmin = dist;
                minflag = i;
            }
        }
        minTest = CharacterList[minflag];
        CInfo = minTest.GetComponent<CharacterInformation>();



        if (distmin < 2)
        {
            UITipsCorpse.show();
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(minTest.tag== "Character1")
                {
                    Character1 = true;
                }
                if (minTest.tag == "Character2")
                {
                    Character2 = true;
                }
                if (minTest.tag == "Character3")
                {
                    Character3 = true;
                }
                videoCG.playVideo(CInfo.clip);
                print(Character1);
                print(Character2);
                print(Character3);

            }
            

        }
        if (distmin >= 2)
        {
           
            UITipsCorpse.hide();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            videoCG.stopVideo();
        }
    }
}
