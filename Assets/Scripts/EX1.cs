using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for ( int i = 1; i <= 10; i++ )
        {
            for (int j = 0; j <= 10; j++)
            {
                int risultato = (i  * j);
                Debug.Log(i + " x " + j + " = " + risultato);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
