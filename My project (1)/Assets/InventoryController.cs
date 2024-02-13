using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public int inventorySize = 5;  // Tamaño del inventario
    public GameObject[] inventorySlots;  // Referencia a los slots del inventario
    public Text notificationText;  // Texto de notificación

    private void Start()
    {
        // Inicializar el inventario
        inventorySlots = new GameObject[inventorySize];
    }

    public void AddItem(GameObject item)
    {
        // Añadir un elemento al inventario
        for (int i = 0; i < inventorySize; i++)
        {
            if (inventorySlots[i] == null)
            {
                inventorySlots[i] = item;
                item.SetActive(false);  // Desactivar el objeto en el mundo
                notificationText.text = "Item añadido al inventario";
                return;
            }
        }

        notificationText.text = "Inventario lleno";
    }

    public void RemoveItem(int slotIndex)
    {
        // Quitar un elemento del inventario
        if (slotIndex >= 0 && slotIndex < inventorySize && inventorySlots[slotIndex] != null)
        {
            inventorySlots[slotIndex].SetActive(true);  // Activar el objeto en el mundo
            inventorySlots[slotIndex] = null;
            notificationText.text = "Item removido del inventario";
        }
    }
}

