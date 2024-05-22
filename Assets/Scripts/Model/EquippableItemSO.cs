using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu(menuName = "Inventory/Equippable Item")]
    public class EquippableItemSO : ItemSO, IDestroyableItem, IItemAction
    {
        public string ActionName => "Equip";

        [field: SerializeField]
        public AudioClip actionSFX { get; private set; }

        [Header("Weapon Info")]
        public GameObject weaponPrefab;
        public float weaponCooldown;
        public int weaponDamage;
        public float weaponRange;

        [Header("Item Visual")]
        public Sprite itemSprite; // Add this field

        public bool PerformAction(GameObject character, List<ItemParameter> itemState = null)
        {
            AgentWeapon weaponSystem = character.GetComponent<AgentWeapon>();
            if (weaponSystem != null)
            {
                weaponSystem.SetWeapon(this, itemState == null ? DefalutParameterList : itemState);
                ActiveInventory.Instance.EquipWeapon(this);
                return true;
            }
            return false;
        }
    }
}
