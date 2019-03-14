using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(SimpleEnemy))]
public class SimpleEnemyEditor : Editor
{
    void OnSceneGUI()
    {
        SimpleEnemy simpleEnemy = (SimpleEnemy)target;

        Vector3 viewAngleA = simpleEnemy.DirectionFromAngle(-simpleEnemy.viewAngle / 2, false);
        Vector3 viewAngleB = simpleEnemy.DirectionFromAngle(simpleEnemy.viewAngle / 2, false);

        Handles.color = simpleEnemy.visibleTargets.Count > 0 ? Color.red : Color.green;

        Handles.DrawWireArc(simpleEnemy.transform.position, Vector3.up, viewAngleA, simpleEnemy.viewAngle, simpleEnemy.viewRadius);
        Handles.DrawLine(simpleEnemy.transform.position, simpleEnemy.transform.position + viewAngleA * simpleEnemy.viewRadius);
        Handles.DrawLine(simpleEnemy.transform.position, simpleEnemy.transform.position + viewAngleB * simpleEnemy.viewRadius);

        Handles.color = Color.red;

        foreach (Transform visibleTarget in simpleEnemy.visibleTargets)
        {
            Handles.DrawLine(simpleEnemy.transform.position, visibleTarget.position);
        }
    }
}
