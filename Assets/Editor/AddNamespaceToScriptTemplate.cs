﻿// https://stackoverflow.com/a/58975868/5980156

using UnityEditor;
using System.IO;

public class AddNamespaceToScriptTemplate : UnityEditor.AssetModificationProcessor
{
    //If there would be more than one keyword to replace, add a Dictionary

    public static void OnWillCreateAsset(string metaFilePath)
    {
        string fileName = Path.GetFileNameWithoutExtension(metaFilePath);

        if (!fileName.EndsWith(".cs"))
            return;

        string actualFilePath = $"{Path.GetDirectoryName(metaFilePath)}{Path.DirectorySeparatorChar}{fileName}";

        string content = File.ReadAllText(actualFilePath);
        string newcontent = content.Replace("#PROJECTNAME#", PlayerSettings.productName);

        if (content != newcontent)
        {
            File.WriteAllText(actualFilePath, newcontent);
            AssetDatabase.Refresh();
        }
    }
}
