using System;
using UnityEngine;

[Serializable]
public class CharacterData
{
    public float MaxHealth;
    public string Name;
}

public class Character
{
    private float _health;
    private float _maxHealth;
    private string _name;

    public string Name => _name;
    public float MaxHealth => _maxHealth;
    public float CurrentHealth => _health;

    public event Action<float> HealthChanged;

    public Character(CharacterData data)
    {
        _health = data.MaxHealth;
        _maxHealth = data.MaxHealth;
        _name = data.Name;
    }

    public void ReduceHealth(float amount)
    {
        Debug.Log(1);
        _health = Mathf.Max(0, _health - amount);
        HealthChanged?.Invoke(_health);
    }
}