using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe : Personaje
{
   
        private int nivel; // Variable privada específica del héroe

        public Heroe(int nivelInicial)
        {
            nivel = nivelInicial;
        }

        public int ObtenerNivel()
        {
            return nivel;
        }
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
