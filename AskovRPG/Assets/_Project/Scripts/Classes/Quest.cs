using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : ScriptableObject
{

    int questId;
   
    public enum QuestCompletionType
    {
        trigger,
        interaction,
        distance
    }


    public Quest(int id)
    {
        questId = id;
    }

}
