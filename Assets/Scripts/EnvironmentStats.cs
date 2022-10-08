using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentStats : MonoBehaviour
{
    public GameObject environment;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        //int cold, int hot, int lowPre, int highPre, int highGrav, int lowGrav, int rad, int cost
        if (environment.name == "Mars")
        {
            sumarEnvironment(-3, 0, -1, 0, -1, 0, -1);
        }
        CharacterStats.instance.InitialEffects();
    }

    private void FixedUpdate()
    {
        CharacterStats.instance.ContinuosEffects();
    }

    private void sumarEnvironment(int cold, int hot, int lowPre, int highPre, int highGrav, int lowGrav, int rad)
    {
        if(cold != 0){
            CharacterStats.instance.coldResistance += cold;
        }else CharacterStats.instance.coldResistance = 0;

        if(hot != 0){
            CharacterStats.instance.hotResistance += hot;
        }else CharacterStats.instance.hotResistance = 0;

        if(lowPre != 0){
            CharacterStats.instance.lowPreassureResistance += lowPre;
        }else CharacterStats.instance.lowPreassureResistance = 0;

        if(highPre != 0){
            CharacterStats.instance.highPreassureResistance += highPre;
        }else CharacterStats.instance.highPreassureResistance = 0;

        if(highGrav != 0){
            CharacterStats.instance.highGravityResistance += highGrav;
        }else CharacterStats.instance.highGravityResistance = 0;

        if(lowGrav != 0){
            CharacterStats.instance.lowGravityResistance += lowGrav;
        }else CharacterStats.instance.lowGravityResistance = 0;

        if(rad != 0){
            CharacterStats.instance.RadResistance += rad;
        }else CharacterStats.instance.RadResistance = 0;

    }
}
