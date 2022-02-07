using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipment,
    Consumables,
    Etc
}

[System.Serializable]
public class Item //: MonoBehaviour
{
    public ItemType itemType;
    public string itemName;
    public Sprite itemImage;
}