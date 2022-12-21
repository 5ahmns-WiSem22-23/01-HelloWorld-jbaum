using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVariablen : MonoBehaviour
{

    int MyInt = 0;
    bool myBool = true;

    int[] myArray = new int[3] { 0, 0, 0 };
    string a = "hallo";


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(bool));

        //Value Type
        int tmp = MyInt;
        MyInt++;
        Debug.Log("myInt: " + MyInt + " tmp: " + tmp);


        //Reference Type
        int[] tmpArray = myArray;
        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;

        Debug.Log("----------- tempArray");
        foreach(int a in tmpArray)
        {
            Debug.Log(a);
        }
        Debug.Log("----------- tempArray");
        foreach (int a in myArray)
        {
            Debug.Log(a);
        }

        string tmpString = a;
        a = "hello";
        Debug.Log("a" + a + "tmpString" + tmpString);

    }

}
