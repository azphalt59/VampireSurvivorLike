using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Instance;

    [System.Serializable]
    public struct HealthStats
    {
        public float Health;
        public float MaxHealth;
        public float HealthRegeneration;
        public float Defense;
        public float InvicibilityTime;
    }
    [System.Serializable]
    public struct AttackStats
    {
        public float damageMultiplier;
        public float radiusAuraMultiplier;
        public float criticalChance;
        public float criticalDamage;
        public int additionalProjectile;
    }
    [System.Serializable]
    public struct GeneralStats
    {
        public int level;
        public float experience;
        public float movementSpeed;
        public float movementSpeedMultiplier;
        public float lootRange;
        public float lootRangeMultiplier;
        public float experienceMultiplier;
        public float cooldownMultiplier;
    }
    [SerializeField] private HealthStats healthStats;
    [SerializeField] private GeneralStats generalStats;
    [SerializeField] private AttackStats attackStats;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
    }
    private void Start()
    {
        healthStats.MaxHealth = healthStats.Health;
        generalStats.level = 1;
    }
    public GeneralStats GetGeneralStats()
    {
        return generalStats;
    }
    public AttackStats GetAttackStats()
    {
        return attackStats;
    }
    public HealthStats GetHealthStats()
    {
        return healthStats;
    }
    
    public void AddExperience(float amount)
    {
        generalStats.experience += amount;
    }
    public void AddLevel()
    {
        generalStats.level++;
    }
}
