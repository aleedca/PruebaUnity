using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardStats : MonoBehaviour
{
    public GameObject Card;
    public Button thisCard;

    private void FixedUpdate() {
        thisCard = GetComponent<Button>();

        for(int i = 0; i < CharacterStats.instance.disabledCardsList.Count; i++){
            if(Card.name == CharacterStats.instance.disabledCardsList[i]){
                thisCard.interactable = false;
            }
        }
    }

    public void stats()
    {
	//int cold, int hot, int lowPre, int highPre, int highGrav, int lowGrav, int rad, int cost
        if(Card.name == "Thermococcus gammatolerans")
        {
            sumarCarta(0,2,0,2,0,0,3,14);
        }

        if(Card.name == "Carnobacterium pleistocenium")
        {
            Debug.Log(Card.name);
            sumarCarta(0,-1,2,2,0,0,0,8);
        }

        if(Card.name == "Tardígrade")
        {
            Debug.Log(Card.name);
            sumarCarta(3,1,3,3,0,3,2,24);
        }

        if(Card.name == "Pleopsidium chlorophanum")
        {
            Debug.Log(Card.name);
            sumarCarta(1,-1,0,0,-1,1,0,0);
        }

        if(Card.name == "Caenorhabditis Elegans")
        {
            Debug.Log(Card.name);
            sumarCarta(-2,-1,0,1,3,0,0,4);
        }

        if(Card.name == "Deinoccocus radiodurans")
        {
            Debug.Log(Card.name);
            sumarCarta(2,1,0,0,0,0,3,10);
        }

        if(Card.name == "Cryomyces antarcticus")
        {
            Debug.Log(Card.name);
            sumarCarta(1,2,3,0,0,3,-2,14);
        }

        if(Card.name == "Methanopyrus kandleri")
        {
            Debug.Log(Card.name);
            sumarCarta(-3,3,0,2,0,0,0,6);
        }
    }

    private void sumarCarta(int cold, int hot, int lowPre, int highPre, int highGrav, int lowGrav, int rad, int cost){
        if(CharacterStats.instance.points >= cost)
        {
            CharacterStats.instance.coldResistance += cold;
            CharacterStats.instance.hotResistance += hot;
            CharacterStats.instance.lowPreassureResistance += lowPre;
            CharacterStats.instance.highPreassureResistance += highPre;
            CharacterStats.instance.highGravityResistance += highGrav;
	        CharacterStats.instance.lowGravityResistance += lowGrav;
            CharacterStats.instance.RadResistance += rad;
            CharacterStats.instance.points -= cost;
            CharacterStats.instance.disabledCardsList.Add(Card.name);
        }
        else Debug.Log("No se compra");
        
    }
}