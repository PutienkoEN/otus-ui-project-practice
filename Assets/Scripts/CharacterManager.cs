using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [SerializeField] private CharacterList characterList;

    private int currentCharacter = 0;
    private float currentHealth;
    private float maxHealth;
    private float currentName;

    public Character GetCurrentCharacter()
    {
        return characterList.characters[currentCharacter];
    }
}