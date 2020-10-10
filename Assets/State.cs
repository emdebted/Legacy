using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject //Instead of Monobehavior, Scriptable Objects must derive from ScriptableObject
{
    [TextArea(20, 24)] [SerializeField] string storyText;
}
