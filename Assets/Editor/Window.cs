using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Window : EditorWindow
{
    static Color color = Color.blue;
    static GameObject prefab;

    [MenuItem("Custom/Criador")]
    static void Init()
    {
        Window window = (Window)GetWindow(typeof(Window));
        window.Show();
    }

    public void OnGUI()
    {
        color = EditorGUILayout.ColorField("Cor", color);
        prefab = (GameObject)EditorGUILayout.ObjectField(prefab, typeof(GameObject), false);
        if (GUILayout.Button("Cria"))
        {
            Instanciar();
        }
    }

    public void Instanciar()
    {
        Instantiate(prefab);
        PrefabUtility.InstantiatePrefab(prefab);
        
    }
    
}
