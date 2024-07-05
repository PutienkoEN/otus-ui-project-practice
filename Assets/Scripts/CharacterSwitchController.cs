using System;

public class CharacterSwitchController
{
    private readonly CharacterListModel characterList;
    private readonly HealthBarView healthBarView;
    private readonly NameButtonView nameButtonView;

    public Character CurrentCharacter { get; private set; }

    public event Action<Character> CurrentCharacterSwitched;

    public CharacterSwitchController(CharacterListModel characterList, HealthBarView healthBarView, NameButtonView nameButtonView)
    {
        this.characterList = characterList;
        this.healthBarView = healthBarView;
        this.nameButtonView = nameButtonView;
    }

    public void SetNextCharacter()
    {
        CharacterData data = characterList.GetNext();
        CurrentCharacter = new Character(data);
        healthBarView.Initialize(new HealthBarViewPresenter(CurrentCharacter));
        nameButtonView.SetName(data.Name);

        CurrentCharacterSwitched?.Invoke(CurrentCharacter);
    } 
}