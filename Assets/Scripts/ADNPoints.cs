using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADNPoints : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("player")){
            CharacterStats.instance.addPoints();
            Destroy(gameObject);
        }
        
    }


}
