using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Quest q = new Quest(gameObject.GetInstanceID());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
