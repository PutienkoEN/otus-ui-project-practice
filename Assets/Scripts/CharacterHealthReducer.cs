using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthReducer
{
    private readonly CharacterSwitchController switchController;
    private readonly Button reduceHealthButton;
    private readonly float reduceHealthAmount;

    public CharacterHealthReducer(CharacterSwitchController switchController, Button reduceHealthButton, float reduceHealthAmount)
    {
        this.switchController = switchController;
        this.reduceHealthButton = reduceHealthButton;
        this.reduceHealthAmount = reduceHealthAmount;

        reduceHealthButton.onClick.AddListener(OnReduceHealthButtonClicked);
    }

    ~CharacterHealthReducer()
    {
        reduceHealthButton.onClick.RemoveListener(OnReduceHealthButtonClicked);
    }

    private void OnReduceHealthButtonClicked()
    {
        switchController.CurrentCharacter.ReduceHealth(reduceHealthAmount);
    }
}
