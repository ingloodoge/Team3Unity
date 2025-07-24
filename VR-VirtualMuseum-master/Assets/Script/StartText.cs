using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        StartCoroutine(starttext());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator starttext()
    {

        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
}
