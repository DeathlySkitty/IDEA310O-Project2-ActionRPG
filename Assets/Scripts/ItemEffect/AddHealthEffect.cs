using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using JetBrains.Annotations;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int HealthIncrease;

    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(HealthIncrease);
        return true;
    }
}
