using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int cost;            // ī�� ���� 
    public string name;         // ī�� �̸�
    public Sprite sprite;       // ī�� �̹���
    public TypeEnum type;

    public string description;  // ī�� ����

    public int attack;          // ī�� ���ݷ�
    public int defense;         // ī�� ����
    public float count;       // ī�� Ȯ��
}

public enum TypeEnum
{
    ����,
    ���,
    ��ų

}

[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Object/ItemSO")]
public class ItemSO : ScriptableObject
{
    public Item[] items;
}
