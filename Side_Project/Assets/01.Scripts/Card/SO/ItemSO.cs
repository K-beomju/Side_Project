using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int cost;            // ī�� ���� 
    public string name;         // ī�� �̸�
    public Sprite sprite;       // ī�� �̹���
    public string type;         // ī�� Ÿ�� 
    public string description;  // ī�� ����

    public int attack;          // ī�� ���ݷ�
    public int defense;         // ī�� ����
    public float percent;       // ī�� Ȯ��
}

[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Object/ItemSO")]
public class ItemSO : ScriptableObject
{
    public Item[] items;
}
