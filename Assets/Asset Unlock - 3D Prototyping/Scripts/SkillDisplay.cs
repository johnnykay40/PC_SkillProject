using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SkillDisplay : MonoBehaviour
{
    string[] skills = { "Fire", "Cure", "Ice", "Lighting", "Water", "Earth", "Haste", "Steal", "Revive" };

    private void Start()
    {
        Debug.Log("Press a number from 1 to 9 to display a skill. Press 0 for a random skill.");
    }

    private void Update()
    {
        for (int i = 0; i <= 9; i++)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                DisplaySkill(i);
            }
        }
    }

    void DisplaySkill(int skillIndex)
    {
        if (skillIndex == 0)
        {
            int randomIndex = Random.Range(0, skills.Length);

            Debug.Log("Random Skill: " + skills[randomIndex]);
        }
        else if (skillIndex >= 1 && skillIndex <= 9)
        {
           Debug.Log("Skill " + skillIndex + ": " + skills[skillIndex - 1]);
        }
        else
        {
           Debug.Log("Invalid input. Press a number from 1 to 9 or 0 for a random skill.");
        }
    }
}
