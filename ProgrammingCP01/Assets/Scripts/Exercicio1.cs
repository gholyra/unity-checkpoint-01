using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// RM: 94633

public class Exercicio1 : MonoBehaviour
{
    [SerializeField] int[] n;
    int placeholder;
    // Start is called before the first frame update
    void Start()
    {
        print("Quest�o 1");
        if (n[0] == n[1] || n[0] == n[2] || n[1] == n[2])
        {
            print("H� n�meros iguais nas vari�veis. Por favor, insira apenas n�meros diferentes entre si.");
        }
        else
        {
            if(n[2] < n[0] && n[2] < n[1])
            {
                placeholder = n[0];
                n[0] = n[2];
                n[2] = placeholder;
                if (n[1] < n[2])
                {
                    placeholder = n[2];
                    n[2] = n[1];
                    n[1] = placeholder;
                }
            }
            if (n[2] < n[1])
            {
                placeholder = n[1];
                n[1] = n[2];
                n[2] = placeholder;
            }
            print("N�meros organizados em ordem crescente: " + n[0] + ", " + n[1] + ", " + n[2]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
