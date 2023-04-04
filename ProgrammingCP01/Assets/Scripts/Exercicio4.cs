using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    [SerializeField] string text;
    // Start is called before the first frame update
    void Start()
    {
        print("Questão 4");
        for(int i = 0; i < 5; i++)
        {
            print(text);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
