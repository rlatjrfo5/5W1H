using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor (typeof (MapMgr))]
public class MapEditor : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        MapMgr map = target as MapMgr;

        map.GenerateMap();
    }
}
