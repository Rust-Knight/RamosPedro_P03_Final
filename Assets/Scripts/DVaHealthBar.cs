using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DVaHealthBar : MonoBehaviour
{
    public Slider healthSlider;
    public Gradient HealthAndArmor;
    public Image fill;

    public void SetMaxHealth(int health)
    {
        healthSlider.maxValue = health;
        healthSlider.value = health;

        HealthAndArmor.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        healthSlider.value = health;

        

        fill.color = HealthAndArmor.Evaluate(healthSlider.normalizedValue);
    }
  
}
