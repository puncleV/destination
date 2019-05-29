using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Scripting;
public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    KeyCode[] choicesButtons = { KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3 };

    State state;
    void Start()
    {
        state = startingState;

        textComponent.text = state.getStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    void ManageState()
    {
        for (int i = 0; i < state.getNextStates().Length; i++)
        {
            if (Input.GetKeyDown(choicesButtons[i]))
            {
                state = state.getNextStates()[i];
                textComponent.text = state.getStory();
                break;
            }
        }
    }
}
