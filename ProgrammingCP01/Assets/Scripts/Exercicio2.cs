using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    [SerializeField] string letter;
    string[] vowels = {"A", "E", "I", "O", "U"};
    int verifier;
    // Start is called before the first frame update
    void Start()
    {
        verifier = 0;
        print("Questão 2");
        for(int i = 0; i < vowels.Length; i++)
        {
            if(letter == vowels[i] || letter == vowels[i].ToLower())
            {
                print("A letra inserida é uma vogal");
                break;
            }
            if(letter != vowels[i])
            {
                verifier++;
            }
        }
        if (verifier == vowels.Length)
        {
            print("A letra inserida é uma consoante");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
