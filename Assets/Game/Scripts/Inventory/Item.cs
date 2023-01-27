using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
[CreateAssetMenu(menuName = "Scriptable object/Item")]
public class Item : ScriptableObject
{
    [Header("Only gameplay")]
    public ItemType type;
    public ActionType actionType;

    [Header("Gun Only")]
    public int clipSize;
    public int damage;
    public int reloadSpeed;

    [Header("Only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;

}

public enum ItemType 
{
    Gun,
    Ammo,
    Crafting,
    Other
}
public enum ActionType
{
    Bolt,
    Semi,
    Auto
}
