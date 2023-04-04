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
        print("Quest�o 6");
        
        for(int i = 0; i < angles.Length; i++)
        {
            sumAngles += angles[i];
        }
        
        for(int i = 0; i < angles.Length; i++)
        {
            if (sumAngles != 180)
            {
                print("Por favor, verifique os valores inseridos, a soma dos �ngulos " +
                    "internos de um tri�ngulo deve ser sempre igual a 180�");
            }
            else
            {
                if (angles[i] == 90)
                {
                    print("Tri�ngulo Ret�ngulo: possui um �ngulo reto");
                    break;
                }
                else if (angles[i] > 90)
                {
                    print("Tri�ngulo Obstus�ngulo: possui um �ngulo obtuso");
                    break;
                }
                else if (angles[0] < 90 && angles[1] < 90 && angles[2] < 90)
                {
                    print("Tri�ngulo Acut�ngulo: possui tr�s �ngulos agudos");
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
