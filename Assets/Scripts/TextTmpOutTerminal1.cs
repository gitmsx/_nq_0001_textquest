using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class TextTmpOutTerminal1 : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textOut;
    bool text0lineShowed = false;
    bool textlineShowed = false;


    public float SpeedText = 0.1f;
    public float SpeedText2 = 0.9f;


    [SerializeField] string[] str = new string[7];
    [SerializeField] string[] strTM = new string[7];

    // Start is called before the first frame update
    void Start()
    {




        str[0] = "Computer <#800000> science is the study <#FFFF00> of computation,<#0000FF> automation, and information.[1]";
        str[1] = "ћассив <#FFFF00> представл€ет набор однотипных данных i and Computer science spans theoretical disciplines (such as algorithms, theory of computation, ";
        str[2] = "information theory,<##006400> and automation) to practical<##016400> disciplines (including the design and implementation ";
        str[3] = "of hardware and software).[2][3][4] Computer science is generally considered an area of academic research and distinct from computer programming.";
        str[4] = "2 Computer science is the study of computation, automation, and information.[1]";

        text0lineShowed = false;


        StartCoroutine(printtext(0, str[0]));
        StartCoroutine(printline());


    }


    IEnumerator printtext(int i, string strT)
    {

        foreach (char c in strT)
        {
            textOut.text += c;
            yield return new WaitForSeconds(SpeedText);
        }
        text0lineShowed = true;
        print("+************");
        yield break;
    }

    IEnumerator printline()
    {
        while (!text0lineShowed)
            yield return new WaitForSeconds(1.1f);
        for (int i = 1; i < str.Length; i++)
        {
            textOut.text += str[i];
            yield return new WaitForSeconds(SpeedText2);
        }

    }








}
