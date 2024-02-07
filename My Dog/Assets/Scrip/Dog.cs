using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    [Header("CLASE DERIVADA")]
    public string Raza;
    Vector3 posicionMouse;

    // Start is called before the first frame update
    void Start()
    {
        //Name = "Pepe";
        Display();
    }

    public override void move()
    {

        posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionMouse.z = 0f;

        Vector3 direccion = (posicionMouse - transform.position).normalized;

        transform.Translate(direccion * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
}
