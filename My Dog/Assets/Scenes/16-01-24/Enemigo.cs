using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : Personaje
{
    
        protected int puntosAtaque; 

        public Enemigo(int puntosAtaqueInicial)
        {
            puntosAtaque = puntosAtaqueInicial;
        }

        public int ObtenerPuntosAtaque()
        {
            return puntosAtaque;
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
