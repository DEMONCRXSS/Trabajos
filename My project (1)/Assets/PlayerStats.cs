using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image hungerBarImage;
    public PlayerController playerController;

    private void Update()
    {
        

        
            Vector3 screenPos = Camera.main.WorldToScreenPoint(playerController.transform.position);

            hungerBarImage.transform.position = screenPos + new Vector3(0f, -50f, 0f);
        
    }
}
