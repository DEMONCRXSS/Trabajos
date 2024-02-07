using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espadas : MonoBehaviour
{

    public int Daño;
    public int Durabilidad;

    public virtual void Ataque()
    {
        Debug.Log("Acción ataque normal.");
    }
}

public class madera : Espadas

{
     
}

