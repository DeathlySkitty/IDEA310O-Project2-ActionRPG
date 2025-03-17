using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using System.Runtime.CompilerServices;

public class WeaponAttackEffect : Weapon.WeaponAttackEffect
{
    public int InitalDamage;
    public int DamageContinued;
    public float Duration;
    public float Interval;

    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        Weapon.AttackData attackDataCurrent = new Weapon.AttackData(target, user);
        attackDataCurrent.AddDamage(StatSystem.DamageType.Electric, InitalDamage);

        target.Stats.Damage(attackDataCurrent);
        user.StartCoroutine(ApplyElectricDoT(user, target));
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        
    }

    private IEnumerator ApplyElectricDoT(CharacterData user, CharacterData target)
    {
        float TimeFrame = 0f;
        while (TimeFrame < Duration)
        {
            yield return new WaitForSeconds(Interval);
            
            Weapon.AttackData dotDamage = new Weapon.AttackData(target, user);
            dotDamage.AddDamage(StatSystem.DamageType.Electric, InitalDamage);
            target.Stats.Damage(dotDamage);
            TimeFrame += Interval;
        }
    }
}
