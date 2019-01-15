using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SevenSegmentDisplay))]
[CanEditMultipleObjects]
public class SevenSegmentDisplayEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SevenSegmentDisplay display = (SevenSegmentDisplay)target;
        if(GUILayout.Button("Increment"))
        {
            display.Increment();
        }
        if (GUILayout.Button("Decrement"))
        {
            display.Decrement();
        }
    }
}
