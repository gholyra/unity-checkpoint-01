using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    [SerializeField] int n1;
    [SerializeField] int n2;
    int sum;
    // Start is called before the first frame update
    void Start()
    {
        print("Quest�o 5");
        sum = n1 + n2;
        print("O resultado da soma �: " + sum);
        if (sum % 2 == 0)
        {
            print(sum + " � um n�mero par");
        }
        else
        {
            print(sum + " � um n�mero �mpar");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
