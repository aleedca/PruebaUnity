using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{   
    public static CharacterStats instance;
    public List<string> disabledCardsList = new List<string>();

    public int points;
    public float health;
    public float speed;
    public float jump;
    public int hotResistance;
    public int coldResistance;
    public int RadResistance;
    public int highGravityResistance;
    public int lowGravityResistance;
    public int highPreassureResistance;
    public int lowPreassureResistance;

    private void Start() {
        this.points = 10;
        this.health = 100;
        this.speed = 30;
        this.jump = 2700;
        this.hotResistance = 0;
        this.coldResistance = 0;
        this.RadResistance = 0;
        this.highGravityResistance = 0;
        this.lowGravityResistance = 0;
        this.highPreassureResistance = 0;
        this.lowPreassureResistance = 0;
    }

    private void Awake()
    {
        if(CharacterStats.instance==null){
            CharacterStats.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    public void heal(int livePoints){
        this.health += livePoints;
    }

    public void damage(float livePoints){
        this.health -= livePoints;
    }

    public void effects(string type){

        if(type == "initials"){
            if(highGravityResistance < 0){
                float percentage = Mathf.Abs(highGravityResistance)/7;
                this.jump -= this.jump*(percentage);
            }
            if(lowGravityResistance < 0){
                float percentage = Mathf.Abs(lowGravityResistance)/7;
                this.jump += this.jump*(percentage);
            }
            if(highPreassureResistance < 0){
                float percentage = Mathf.Abs(highGravityResistance)/7;
                this.speed -= this.speed*(percentage);
            }
            if(lowPreassureResistance < 0){
                float percentage = Mathf.Abs(lowPreassureResistance)/7;
                this.speed += this.speed*(percentage);
            }

        }
        else if(type == "continuos"){
            if(hotResistance < 0){
                float percentage = Mathf.Abs(hotResistance)/7;
                this.damage(1*percentage);
            }
            if(coldResistance < 0){
                float percentage = Mathf.Abs(coldResistance)/7;
                this.damage(1*percentage);
            }
            if(RadResistance < 0){
                float percentage = Mathf.Abs(RadResistance)/7;
                this.damage(1*percentage);
            }
        }

    }

    public void addPoints(){
        this.points += 1;
    }


    public void ContinuosEffects()
    {
        effects("continuos");
    }

    
    public void InitialEffects()
    {
        effects("initials");
    }
}
