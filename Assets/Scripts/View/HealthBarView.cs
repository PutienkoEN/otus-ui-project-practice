using System;
using TMPro;
using UnityEngine;
using Slider = UnityEngine.UI.Slider;

public class HealthBarView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private Slider healthSlider;

    private IHealthBarViewPresenter _currentPresenter;

    public void Initialize(IHealthBarViewPresenter presenter)
    {
        if (_currentPresenter != null)
            _currentPresenter.HealthChanged -= UpdateHealth;

        healthSlider.maxValue = presenter.MaxHealth;
        UpdateHealth(presenter.CurrentHealth);

        _currentPresenter = presenter;
        _currentPresenter.HealthChanged += UpdateHealth;
    }

    private void UpdateHealth(float health)
    {
        Debug.Log("2");
        healthText.text = "Health: " + health;
        healthSlider.value = health;
    }
}

public interface IHealthBarViewPresenter
{
    event Action<float> HealthChanged;
    float MaxHealth { get; }
    float CurrentHealth { get; }
}

public class HealthBarViewPresenter : IHealthBarViewPresenter
{
    private Character _character;

    float IHealthBarViewPresenter.MaxHealth => _character.MaxHealth;
    float IHealthBarViewPresenter.CurrentHealth => _character.CurrentHealth;

    public HealthBarViewPresenter(Character character)
    {
        _character = character;
    }

    event Action<float> IHealthBarViewPresenter.HealthChanged
    {
        add
        {
            _character.HealthChanged += value;
        }

        remove
        {
            _character.HealthChanged -= value;
        }
    }
}