using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    private int intEins = 0;
    private int intZwei = 1;




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hier steht der arithmetische Operator " + (intEins + intZwei).ToString());

        Debug.Log("Hier steht der Gleichheitsoperator " + (intEins == intZwei).ToString());

        Debug.Log("Hier steht der Vergleichssoperator " + (intEins < intZwei).ToString());

        Debug.Log("Hier steht der logische Operator " + (true && true).ToString());

        Debug.Log("Hier steht der Zuweisungssoperator " + (intEins += 1).ToString());

    }

  
}
