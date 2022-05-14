using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntityHPbar : MonoBehaviour
{
    private Slider slider;
    private RectTransform rTr;
    private Coroutine co = null;


    private void Awake()
    {
        slider = GetComponent<Slider>();
        rTr = GetComponent<RectTransform>();
    }

    public void SetValue(float health, float maxhelath)
    {
        if (co != null)
        {
            StopCoroutine(co);
        }
        co = StartCoroutine(DamageReduce(health, maxhelath));

    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }



    IEnumerator DamageReduce(float curHp, float maxHp)
    {
          slider.value = curHp / maxHp; 
          yield return null; 
    }


    public void Reset(Vector3 pos, float value) // �����̴� ��ġ ����
    {
        rTr.position = pos;
        slider.value = value;
    }


    public void SetPosition(Vector3 pos) // �����̴� ������
    {
        rTr.position = pos;
    }
}
