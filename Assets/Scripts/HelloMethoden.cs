using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    //2) Instanzvariable nutzen
    private int startValue2 = 0;

    //3) Der Wert der dazugezählt wird ist bei Deklaration noch nicht bekannt
    // z.B. Random oder User Input
    private int startValue3 = 0;

    //4) Copy by Value
    private int startValue4 = 0;

    void Start()
    {
        //1 Verwende Start Methode
        Debug.Log("Hallo Methoden!");



        //at 2 Instanzvariable nutzen 
        Debug.Log("before Start Vaue: " + startValue2);
        IncrementByOne();
        Debug.Log("after startValue: " + startValue2);

        //at 3
        Debug.Log("after startValue3: " + startValue3);
        Debug.Log("after startValue3: " + startValue3);

        //at 4
        DecrementByOne(3);
    }

    private void DecrementByOne(int val)
    {
        startValue3--;
        Debug.Log("val: +val");
    }


    private void IncrementByX(int valToAdd)
    {
        startValue3 += valToAdd;
    }

    private void IncrementByOne()
    {
        startValue2++;
        //startValue++ = startValue +1;
    }

}

