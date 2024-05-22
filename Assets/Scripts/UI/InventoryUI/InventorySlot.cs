using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Inventory.Model;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] private EquippableItemSO equippableItem;
    [SerializeField] private Image itemImage; // Reference to the UI Image component
    [SerializeField] private Button equipButton; // Reference to the button component

    private void Start()
    {
        if (equipButton != null)
        {
            equipButton.onClick.AddListener(EquipWeapon); // Add listener to button click
        }

        UpdateSlotImage();
    }

    public EquippableItemSO GetEquippableItem()
    {
        return equippableItem;
    }

    public void SetEquippableItem(EquippableItemSO item)
    {
        equippableItem = item;
        UpdateSlotImage();
    }

    private void EquipWeapon()
    {
        if (equippableItem != null)
        {
            equippableItem.PerformAction(GameObject.FindWithTag("Player")); // Assuming the player has the tag "Player"
        }
    }

    public void ClearEquippableItem()
    {
        equippableItem = null;
        UpdateSlotImage();
    }

    private void UpdateSlotImage()
    {
        if (itemImage != null)
        {
            if (equippableItem != null && equippableItem.itemSprite != null)
            {
                itemImage.sprite = equippableItem.itemSprite;
                itemImage.enabled = true;
                itemImage.transform.SetAsLastSibling(); // Ensure the image is on top
            }
            else
            {
                itemImage.enabled = false; // Hide image if no item is equipped
            }
        }
        else
        {
            Debug.LogError("itemImage is not assigned in the InventorySlot script.");
        }
    }
}
