using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Scripting;
public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State state;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = state.getStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
