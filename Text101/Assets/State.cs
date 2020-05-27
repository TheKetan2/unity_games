using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="State")]

/*
 Fester. Everywhere. Armed with mostly gas-powered flingers.
At least 10 of them guarding the doors of the tunnel.

could try punching my way through, or sneaking the long way to the emergency exit.

What should I do?
1. Take them head on, rush to the 10 guards.
3. Sneak my way to the emergency Exit.
*/
public class State : ScriptableObject {
    [TextArea(10,14)] [SerializeField] string storyText;

    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextState() {
        return nextStates;
    }
}
