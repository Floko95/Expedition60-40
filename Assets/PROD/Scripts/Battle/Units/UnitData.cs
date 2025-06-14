using System.Collections.Generic;
using OSLib.StatSystem;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitData", menuName = "Ex32/UnitData")]
public class UnitData : SerializedScriptableObject
{
    [SerializeField] public string unitName;
    [SerializeField] public Sprite portrait;
    [SerializeField] public Unit prefab;
    [SerializeField] public bool isEnemy;

    [Title("Stats")]
    [SerializeField] public Dictionary<StatType, float> stats;
    [SerializeField] public List<ElementInteraction> elementInteractions;
    
    [SerializeField] public int energy;

    [Space(50), SerializeField] public List<AbilityData> abilities;
    [SerializeField] public AbilityData attackAbility;
    [SerializeField] public AbilityData counterAbility;
    
    public ElementReaction GetReaction(ElementType type) {
        foreach (var interaction in elementInteractions) {
            if (interaction.type == type)
                return interaction.reaction;
        }

        return ElementReaction.Normal;
    }

    
}
