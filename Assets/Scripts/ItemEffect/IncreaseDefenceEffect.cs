using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class IncreaseDefenceEffect : UsableItem.UsageEffect
{
    public int DefenseAmount;
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeDefense(DefenseAmount);
        return true;
    }
}
