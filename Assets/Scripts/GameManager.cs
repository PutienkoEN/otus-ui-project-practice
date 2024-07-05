using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("CharacterSwitchController")]
    [SerializeField] private CharacterList _characterList;
    [SerializeField] private HealthBarView _healthBarView;
    [SerializeField] private NameButtonView _nameButtonView;

    [Header("CharacterHealthReducer")]
    [SerializeField] private float _reduceHealthAmount;
    [SerializeField] private Button _reduceButton;

    private void Awake()
    {
        CharacterListModel model = new CharacterListModel(_characterList);
        CharacterSwitchController characterSwitchController = new CharacterSwitchController(model, _healthBarView, _nameButtonView);
        CharacterHealthReducer characterHealthReducer = new CharacterHealthReducer(characterSwitchController, _reduceButton, _reduceHealthAmount);
        CharacterDeathObserver characterDeathObserver = new CharacterDeathObserver(characterSwitchController);

        characterSwitchController.SetNextCharacter();
    }
}