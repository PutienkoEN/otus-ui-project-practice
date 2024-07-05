using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

[CreateAssetMenu(fileName = "CharacterList", menuName = "Configuration/New Character List")]
public class CharacterList : ScriptableObject
{
    [SerializeField] public List<CharacterData> characters;
}