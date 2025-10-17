using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Text : MonoBehaviour
{  
    [SerializeField] TMP_Text Message;
    [SerializeField] int charnum = 0;
    [SerializeField] public bool isscrolling = true;
    string actual = "Greetings Dr. McClean,\nWelcome to our company, Ocean Blue Inc. We are glad that you have taken on this responsibility of becoming one of our new ocean conservationists. Your work here will be essential to making our oceans cleaner and bluer, and our world, brighter.\n\nYour job is to rid the oceans of the harmful waste left by a group of irresponsible companies. We cannot afford to let this garbage hit the sea floor, and hurt marine life.";
    string Screen = "";
    public GameObject Next;
    //int charnum = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScrollingMethod();

    }

    public void  ScrollingMethod()
    {
        if (Input.anyKeyDown || charnum == actual.Length - 1)
        {
            isscrolling = false;
            Screen = actual;
            Message.text = Screen;
            Next.SetActive(true);
            

        }
        if (Time.frameCount % 5 == 0 && isscrolling)
        {
            Screen += actual[charnum];
            charnum++;
            Message.text = Screen;
        }
    }
}
