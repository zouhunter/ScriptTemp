using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEditor.ProjectWindowCallback;
using System.Text.RegularExpressions;
using System;
using System.Text;

public class ScriptTempMenu : MonoBehaviour
{
    [MenuItem(ScriptTempUtility.Menu_CreateUIScript, false, 80)]
    public static void CreateUGUIScript()
    {
        ScriptTempUtility.CreateScriptUtil("NewUIScript.cs", ScriptTempUtility.UIScriptPath);
    }

    [MenuItem(ScriptTempUtility.Menu_CreateEditorScript, false, 70)]
    public static void CreateEventCS()
    {
        ScriptTempUtility.CreateScriptUtil("NewEditorScript.cs", ScriptTempUtility.EditorScriptPath);
    }

}
