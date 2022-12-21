using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{
    bool wahr = true;
    bool falsch = false;
    int a = 2;
    int b = 3;
    int i = 5;



    // Start is called before the first frame update
    void Start()
    {

        //Wenn wahr true ist UND falsch false is wird Debug.Log ausgeführt
        if (wahr == true && false == false)
        {
            Debug.Log("funktioniert");
        }

        //Wenn eines der beiden falsch ist, wird else ausgeführt
        else
        {
            Debug.Log("funktioniertNicht");
        }

        if(a == b)
        {
            Debug.Log("a ist b");
        }

        else if (a < b)
        {
            Debug.Log("a ist nich b");
        }

        if (a > b)
        {
            if(wahr == true && falsch == false)
            {
                Debug.Log("a ist kleiner als b");
            }
        }

        //wenn integer wert vom case erreicht wird dann wird Debug Log ausgegeben und weitere Fälle werden nicht berechnet

        switch (i)
        {
            case 0:Debug.Log("case " + i); break;
            case 1: Debug.Log("case " + i); break;
            case 2: Debug.Log("case " + i); break;
            case 3: Debug.Log("case " + i); break;
            case 4: Debug.Log("case " + i); break;
            case 5: Debug.Log("case " + i); break;
            case 6: Debug.Log("case " + i); break;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
