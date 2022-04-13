using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pets : MonoBehaviour
{
    public string inicialAnimal;
    public int dias;

    // Start is called before the first frame update
    void Start()
    {
        int G = dias * 300;
        int PP = dias * 400;
        int PG = dias * 700;
        int precioG = G / 100 * 80;
        int precioPP = PP / 100 * 80;
        int precioPG = PG / 100 * 80;

        if (inicialAnimal != "G" & inicialAnimal != "PP" & inicialAnimal != "PG")
        {
            Debug.Log("Error, las letras disponibles son G,PP,PG");
        }
        else if (dias < 3)
        {
            Debug.Log("Error, el minimo de dias es 3");
        }
        else if (inicialAnimal == "G")       
        {
            Debug.Log("Para ese período necesita " + G + " gramos");
            Debug.Log("Va a gastar " + precioG + " pesos para el alimento");

        }
        else if (inicialAnimal == "PP")
        {
            Debug.Log("Para ese período necesita " + PP + " gramos");
            Debug.Log("Va a gastar " + precioPP + " pesos para el alimento");

        }
        else if (inicialAnimal == "PG")
        {
            Debug.Log("Para ese período necesita " + PG + " gramos");
            Debug.Log("Va a gastar " + precioPG + " pesos para el alimento");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
