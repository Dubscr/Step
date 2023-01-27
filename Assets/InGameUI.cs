using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : MonoBehaviour
{
    [SerializeField]
    private GameObject inGameMenu;
    [SerializeField]
    private GameObject inventoryMenu;
    [SerializeField]
    private FirstPersonController playerController;

    void Update()
    {
        InputHandler();
    }

    private void InputHandler()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscapePressed();
        }
        */

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TabPressed();
        }
    }

    public void EscapePressed()
    {
        // Toggle menu off or on
        inGameMenu.SetActive(!inGameMenu.activeSelf);

        if (inGameMenu.activeSelf)
        {
            LockCursorState(false);
        }
        else
        {
            LockCursorState(true);
        }
    }

    public void TabPressed()
    {
        // Toggle inventory menu off or on
        inventoryMenu.SetActive(!inventoryMenu.activeSelf);

        if (inventoryMenu.activeSelf)
        {
            LockCursorState(false);
        } 
        else
        {
            LockCursorState(true);
        }
    }

    public void LockCursorState(bool locked)
    {
        if (locked)
        {
            // Make cursor dissapear and lock mouse to middle
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            // Make camera go back to moving
            playerController.cameraCanMove = true;
        } else
        {
            // Make cursor appear and can move mouse freely
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            // Make camera not move when browsing menu
            playerController.cameraCanMove = false;
        }
    }
}
