using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEditor.ProjectWindowCallback;
using System.Text.RegularExpressions;
using System;
using System.Text;
using System.Reflection;

public class ScriptTempUtility
{
    public static string UIScriptPath
    {
        get
        {
            var path = AssetDatabase.GUIDToAssetPath("3b09288f886811b479d032de134ad0be");
            return path;
        }
    }
    public static string EditorScriptPath
    {
        get
        {
            var path = AssetDatabase.GUIDToAssetPath("186573cc883d37a4faac6d460da92f20");
            return path;
        }
    }

    public const string Menu_CreateUIScript = "Assets/Create/User Script/UGUI";
    public const string Menu_CreateEditorScript = "Assets/Create/User Script/Editor";
    public static void CreateScriptUtil(string path, string templete)
    {
        MethodInfo method = typeof(ProjectWindowUtil).GetMethod("CreateScriptAsset",
            BindingFlags.Static | BindingFlags.NonPublic);
        if (method != null)
            method.Invoke(null, new object[] { templete, path });
    }
}

