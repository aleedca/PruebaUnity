using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textPoints : MonoBehaviour
{

    public TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        Text = FindObjectOfType<TextMeshProUGUI>();    
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = CharacterStats.instance.points.ToString();
    }
}
