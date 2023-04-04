using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio6 : MonoBehaviour
{
    [SerializeField] int[] angles;
    int sumAngles;
    // Start is called before the first frame update
    void Start()
    {
        print("Questão 6");
        
        for(int i = 0; i < angles.Length; i++)
        {
            sumAngles += angles[i];
        }
        
        for(int i = 0; i < angles.Length; i++)
        {
            if (sumAngles != 180)
            {
                print("Por favor, verifique os valores inseridos, a soma dos ângulos " +
                    "internos de um triângulo deve ser sempre igual a 180º");
            }
            else
            {
                if (angles[i] == 90)
                {
                    print("Triângulo Retângulo: possui um ângulo reto");
                    break;
                }
                else if (angles[i] > 90)
                {
                    print("Triângulo Obstusângulo: possui um ângulo obtuso");
                    break;
                }
                else if (angles[0] < 90 && angles[1] < 90 && angles[2] < 90)
                {
                    print("Triângulo Acutângulo: possui três ângulos agudos");
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
