using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    // ... (resto del código)

    private bool isInventoryOpen = false;
    public GameObject inventoryPanel;

    private void Start()
    {
        // Inicializar el inventario
        inventorySlots = new GameObject[inventorySize];
        CloseInventory();
    }

    public void ToggleInventory()
    {
        // Alternar entre abrir y cerrar el inventario
        if (isInventoryOpen)
        {
            CloseInventory();
        }
        else
        {
            OpenInventory();
        }
    }

    private void OpenInventory()
    {
        // Activar el panel del inventario
        inventoryPanel.SetActive(true);
        isInventoryOpen = true;
    }

    private void CloseInventory()
    {
        // Desactivar el panel del inventario
        inventoryPanel.SetActive(false);
        isInventoryOpen = false;
    }

    // Resto del código...

    // Asegúrate de que estas líneas estén en tu script
    public int inventorySize = 5;  // Tamaño del inventario
    public GameObject[] inventorySlots;  // Referencia a los slots del inventario
    public Text notificationText;  // Texto de notificación

    // Resto del código...
}


