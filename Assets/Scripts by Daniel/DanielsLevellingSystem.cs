using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanielCairney
{
    /// <summary>
    /// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining XP and detecting when we should level up.
    /// </summary>
    public class LevellingSystem : MonoBehaviour
    {
        // TODO XP 1/13 Declare a new variable to track the current amount of XP we have accumulated (our current XP).
        private float currentExperience;
        // TODO XP 2/13 Declare a new variable to track our current Level.
        private float currentLevel;
        // TODO XP 3/13 Declare a new variable to track the amount of XP required to level-up (our current Level Up Threshold).
        private float levelUpThreshold;

        private void Start()
        {
            // TODO XP 4/13: Set our current level to one.
            currentLevel = 1;
            // TODO XP 5/13: Set our current XP to zero.
            currentExperience = 0;
            // TODO XP 6/13: Set our current XP Threshold to be our level multiplied by our 100.
            levelUpThreshold = currentLevel * 100;
            // TODO XP 7/13: Debug out our starting values of our level, XP and current XP threshold.
            Debug.Log("Current Level " + currentLevel);
            Debug.Log("Current Experience " + currentExperience);
            Debug.Log("Level Up Threshold" + levelUpThreshold);
            // TODO XP 8/13: Increase the current XP by a random amount between 50 and 100.

            // TODO XP 9/13: Debug out our current XP.

            // TODO XP 10/13: Check if our current XP is more than our threshold.

            // TODO XP 11/13: If it is, then let's increase out level by one.

            // TODO XP 12/13: Let's also increase recalculate our current XP threshold as we've levelled up.

            // TODO XP 13/13: Debug out our new level value, as well as our current XP and the next threshold we need to hit.

            // TODO XP Final: Add code comments describing what you hope your code is doing throughout this script.

            // TODO XP Bonus: Adjust our character's stats ("runSpeed" and/or "jumpStrength") based on their level. (Hint: You'll need a reference to the SimpleCharacterController script!)

        }
    }
}
