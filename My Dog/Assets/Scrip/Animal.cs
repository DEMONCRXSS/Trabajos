using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [Header("CLASE BASE")]
    public string Name = "Animal";
    public float speed = 5f;
    Vector3 posicionMouse;

    public virtual void move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionMouse.z = 0f;
        }

        Vector3 direccion = (posicionMouse - transform.position).normalized;

        transform.Translate(direccion * speed * Time.deltaTime);
    }




    public virtual void Display()
    {
        Debug.Log("El nombre del anima es: " + Name);
    }
}
