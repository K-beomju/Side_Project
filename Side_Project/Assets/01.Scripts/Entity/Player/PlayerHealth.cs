using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : LivingEntity
{
    #region SerializeField Fields
    [SerializeField] private Vector3 offset;
    #endregion

    #region private Fields
    #endregion

    protected override void Awake()
    {
      
    }

    protected override void Start()
    {
        base.Start();
    }

    public override void OnDamage(int damage)
    {
        base.OnDamage(damage);
    }

    public override void Die()
    {

    }
}
