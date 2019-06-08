using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CanEditMultipleObjects, CustomEditor(typeof(Personagem22), true)]
public class Qualquer : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Personagem22 personagem = (Personagem22) this.target;


        personagem.nivel = (int)EditorGUILayout.Slider("Nivel: ", personagem.nivel,0, 100);
        personagem.vida = (int)(personagem.nivel * personagem.hpMultiply);
        EditorGUILayout.LabelField("HP: " + personagem.vida);
    }

}