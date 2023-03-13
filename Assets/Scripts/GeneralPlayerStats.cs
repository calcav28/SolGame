using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GeneralPlayerStats : MonoBehaviour
{
    //currency earned from all games
    public int superPoints;
    public int skillProPoints;
    public int stealthProPoints;


    //get methods for points
    public int getSuperPoints()
    {
        return superPoints;
    }

    public int getSkillProPoints()
    {
        return skillProPoints;
    }

    public int getStealthProPoints()
    {
        return stealthProPoints;
    }
}
