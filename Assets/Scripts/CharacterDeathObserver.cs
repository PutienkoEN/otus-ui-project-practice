public class CharacterDeathObserver
{
    private readonly CharacterSwitchController characterSwitchController;

    private Character _currentTarget;

    public CharacterDeathObserver(CharacterSwitchController switchController)
    {
        this.characterSwitchController = switchController;

        characterSwitchController.CurrentCharacterSwitched += OnCharacterSwitched;
    }

    ~CharacterDeathObserver()
    {
        characterSwitchController.CurrentCharacterSwitched -= OnCharacterSwitched;
    }

    private void OnCharacterSwitched(Character character)
    {
        ResetCurrentTarget();
        _currentTarget = character;
        _currentTarget.HealthChanged += OnCharacterHealthChanged;
    }

    private void OnCharacterHealthChanged(float newValue)
    {
        if (newValue <= 0)
        {
            ResetCurrentTarget();
            characterSwitchController.SetNextCharacter();
        }
    }

    private void ResetCurrentTarget()
    {
        if (_currentTarget != null)
        {
            _currentTarget.HealthChanged -= OnCharacterHealthChanged;
            _currentTarget = null;
        }
    }
}