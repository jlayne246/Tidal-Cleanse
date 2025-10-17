using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
     
    Text coolText;
    float delay;
    int StopTime;
    public GameObject Next;
    // Start is called before the first frame update
    void Start() {
        //Next.SetActive(false);
        Next.SetActive(false);
    }

    /*IEnumerator DisplayButton()
    {
        //yield return new WaitForSeconds(20);
        //Next.SetActive(true);
    }*/

    private void Awake()
    {
        delay = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //delay += Time.deltaTime;

        if (coolText.isscrolling==false)
        {
            coolText.ScrollingMethod();
        }

        if (Next.activeSelf)
        {
            
        }
    }
    
}
