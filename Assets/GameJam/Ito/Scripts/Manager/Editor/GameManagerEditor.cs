using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameManager))]
public class GameManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        var gameManager = target as GameManager;

        GUILayout.Space(10f);

        if (GUILayout.Button("鍵をゲットする(デバッグ用)"))
        {
            gameManager.GetKeyItem();
        }
    }
}
