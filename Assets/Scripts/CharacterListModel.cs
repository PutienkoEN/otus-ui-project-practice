public class CharacterListModel
{
    private readonly CharacterList list;
    private int _currentIndex = 0;

    public CharacterListModel(CharacterList list)
    {
        this.list = list;
    }

    public CharacterData GetNext()
    {
        if (_currentIndex >= list.characters.Count)
            _currentIndex = 0;

        return list.characters[_currentIndex++];
    }
}