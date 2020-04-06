﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{/*
    #region Singleton

    public static InventoryUI instance;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of inventory found");
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
    #endregion
    */
    public Transform itemsParent;
    Inventory inventory;
    InventorySlot[] slots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.GetInventoryInstance();
        inventory.OnItemChangedCallback += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                Debug.Log("All slots taken!");
             }
        }
        Debug.Log("UpdatingUI");
        this.transform.gameObject.SetActive(true);
    }
}
