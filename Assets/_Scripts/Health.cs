using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHp;
    [SerializeField] private float maximumHp;
    [SerializeField] private float current;

    public UnityEvent<float> damaged;
    public UnityEvent<float, float> healthUpdated;
    public UnityEvent death;

    [SerializeField] Image healthBar;

    
    
    public float Current
    {
        get => current;
        private set
        {
            current = Mathf.Clamp(value, 0, Max);
            healthBar.fillAmount = current/maximumHp;
            healthUpdated?.Invoke(current, Max);
        }
    }
    
    public float Max 
    { 
        get => maximumHp; 
        private set => maximumHp = Mathf.Clamp(value, 0, float.MaxValue); 
    }

    public bool IsDead => Current <= 0 ;
    
    private void Awake()
    {
        Current = startingHp;
    }

    public void Damage(float damage)
    {
        if(damage <= 0)
            return;
        
        if (IsDead)
            return;
        
        Current -= damage;
        damaged?.Invoke(damage);
        
        if(IsDead)
            death?.Invoke();
    }
    
    public void Heal(float healing)
    {
        if(healing <= 0)
            return;
        
        if(IsDead)
            return;

        Current += healing;
    }
    
    public void SetMaxHealth(float newMax)
    {
        if (newMax <= 0)
            return;
        
        Max = newMax;
        
        if(Current > Max)
            Current = Max;
    }

    private void OnValidate()
    {
        if(maximumHp <= 0)
        {
            Debug.LogWarning($"{gameObject.name}'s Maximum HP needs to be greater than 0");
            return;
        }
        
        if(startingHp > maximumHp)
        {
            Debug.LogWarning($"{gameObject.name}'s Starting HP is more than Maximum HP. Updating MaxHP");
            
            //Not sure I like this functionality. Can be removed if its more annoying than helpful
            maximumHp = startingHp;
        }
    }
}
