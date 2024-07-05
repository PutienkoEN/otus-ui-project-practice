using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private CharacterList characterList;
    [SerializeField] private HealthBarView healthBarView;

    public void Start()
    {
        var character = characterList.characters[0];
        healthBarView.UpdateHealth(character.Health);
    }
}