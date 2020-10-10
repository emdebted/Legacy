using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Needed for the "Text" type of variable

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent; // SerializeField allows us to edit the field within the Unity inspector

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "THIS IS A TEST";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
