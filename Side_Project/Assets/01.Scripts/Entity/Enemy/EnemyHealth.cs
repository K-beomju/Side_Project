using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyHealth : LivingEntity
{
    [SerializeField] private HpSlider hpSlider;
    private EnemyAnimation ea;


    [ContextMenu("Damage")]
    public void Hit()
    {
        OnDamage(1);
    }

    protected override void Awake()
    {
        ea = GetComponent<EnemyAnimation>();
    }

    protected override void Start()
    {
        base.Start();
        hpSlider.SetHpbar(curHp, maxHp);
        OnDeath += DeathEvent;
    }

    public override void OnDamage(int damage)
    {
        base.OnDamage(damage);
        hpSlider.SetHpbar(curHp, maxHp);

        if (curHp > 0) // ���� ü���� 0 �̻��϶��� �ִϸ��̼� ����
            ea.HitState();
        else
            hpSlider.SetDeath();

    }

    public void DeathEvent()
    {
        ea.DieState();

    }

    public override void Die()
    {
        base.Die();
    }
}
