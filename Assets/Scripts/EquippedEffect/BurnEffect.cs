using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class BurnEffect : EquipmentItem.EquippedEffect
{
     public int StrengthModifier;
     public int Speed;

     public override void Equipped(CharacterData user)
     {
          user.Stats.ChangeStrength(StrengthModifier);
          user.Stats.ChangeAgility(Speed);
     }
     
     public override void Removed(CharacterData user)
     {
          user.Stats.ChangeStrength(StrengthModifier);
          user.Stats.ChangeAgility(Speed);
     }
}
