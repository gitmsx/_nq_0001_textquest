using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class TextTmpOutTerminal2 : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textOut;

    private Coroutine CourutineWork;
    public float SpeedText = 0.1f;
    public float SpeedText2 = 0.9f;


    [SerializeField] string[] str = new string[7];
    [SerializeField] string[] strTM = new string[7];

    // Start is called before the first frame update
    void Start()
    {




        str[0] = "Computer1<#800000>23science is the study12<#FFFF00>34 of computation,1123<#0000FF>45678 automation, and information.[1]<";
        str[1] = "\n?????? <#FFFF00> ???????????? ????? <#800000>?????????? ?????? i <#FF00FF>and Computer science spans theoretical disciplines (such as algorithms, theory of computation, ";
        str[2] = "\ninformation theory,<##006400> and automation) to practical<##016400> disciplines (including the design and implementation ";
        str[3] = "\nof hardware and software).[2][3][4] Computer science is generally considered an area of academic research and distinct from computer programming.";
        str[4] = "\n2 Computer <#00FFFF>science is the study of computation, automation, and information.[1]";


        CourutineWork = null;
        //str.Length
        for (int i = 0; i < 1; i++)
        CourutineWork = StartCoroutine(printtext2(i, str[i]));
        CourutineWork = StartCoroutine(printline());



        // StartCoroutine(printline());


    }


    IEnumerator printtext(int i, string strT)
    {
        while (CourutineWork != null)
            yield return new WaitForSeconds(0.2f);
        
        foreach (char c in strT)
        {
            textOut.text += c;

            yield return new WaitForSeconds(SpeedText);
        }

        CourutineWork = null;
        yield break;
    }



    IEnumerator printtext2(int i, string strT)
    {
        while (CourutineWork != null)
            yield return new WaitForSeconds(0.2f);
        char c;

        for (int j = 0; j < strT.Length; j++)
        {
            c = strT[j];

            if ((strT[j] == '<') && (j + 1 < strT.Length) && strT[j + 1] == '#')
            {
                for (int k = j; k < j + 10; k++)
                    textOut.text += strT[k];
                j += 9;
            }
            else
            {
                textOut.text += c;
                yield return new WaitForSeconds(SpeedText);
            }
        }
        CourutineWork = null;
        yield break;
    }



    IEnumerator printline()
    {
        while (CourutineWork != null)
            yield return new WaitForSeconds(0.2f);
        for (int i = 1; i < str.Length; i++)
        {
            textOut.text += str[i];
            yield return new WaitForSeconds(SpeedText2);
        }

    }


}
