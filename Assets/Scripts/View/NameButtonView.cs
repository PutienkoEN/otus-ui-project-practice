using TMPro;
using UnityEngine;

public class NameButtonView : MonoBehaviour
{
    [SerializeField] private TMP_Text _name;

    public void SetName(string name)
    {
        _name.text = name;
    }
}