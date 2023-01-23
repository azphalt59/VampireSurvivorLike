using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelManager : MonoBehaviour
{
    [SerializeField] private List<float> experienceNeededByLevel;
    [SerializeField] private float baseExperienceNeeded = 100f;
    [SerializeField] private float experienceToLevelUp;
    [SerializeField] private float experienceMultiplierNeeded = 0.25f;
    [SerializeField] private int levelCount = 30;
    private int nextLevel = 2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < experienceNeededByLevel.Count; i++)
        {
            if (i == 0)
            {
                experienceNeededByLevel[i] = baseExperienceNeeded;
                experienceToLevelUp = baseExperienceNeeded;
            }
            if(i > 0)
            {
                experienceNeededByLevel[i] = experienceToLevelUp * (1 + experienceMultiplierNeeded);
                experienceToLevelUp = experienceNeededByLevel[i];
            }  
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerStats.Instance.SetExpToUp(experienceNeededByLevel[PlayerStats.Instance.GetLevel()]);
        if(PlayerStats.Instance.GetGeneralStats().experience > experienceNeededByLevel[nextLevel-2])
        {
            nextLevel++;
            PlayerStats.Instance.AddLevel();
        }
    }
}
