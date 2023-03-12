using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SkillGameStats : MonoBehaviour
{
    public string skillGameType; //shooting gallery, duel, 
    public string skillGameDifficulty; //easy, normal, hard
    public bool wantsOnline; //if game type has vs player mode, picks that
}
