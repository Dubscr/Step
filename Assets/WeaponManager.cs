using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    private Camera cam;

    [Header("Weapon inventory")]
    public InventoryManager inventoryManager;

    [Header("Gun")]
    public Transform weaponHolder;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GetSelectedItem();
        }
    }
    public void GetSelectedItem()
    {
        Item receivedItem = inventoryManager.GetSelectedItem(false);
        if (receivedItem != null)
        {
            if(receivedItem.type == ItemType.Gun)
            Shoot();
        }
    }
    public void Shoot()
    {
        if(Physics.Raycast(transform.position, cam.transform.forward, out RaycastHit hit))
        {
            Debug.Log(hit.point.ToString());
        }
    }
}
