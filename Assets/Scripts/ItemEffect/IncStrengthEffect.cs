using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class IncStrengthEffect : UsableItem.UsageEffect
{
    public int StrengthIncrease;
    public override bool Use(CharacterData user)
    {
        user.Stats.AddModifier.StrengthIncrease;
        return false;
    }
}
