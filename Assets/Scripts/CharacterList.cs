using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterList", menuName = "Configuration/New Character List")]
public class CharacterList : ScriptableObject
{
    [SerializeField] public List<Character> characters;
}