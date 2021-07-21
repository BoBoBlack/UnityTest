using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class BuildWebgl : MonoBehaviour
{
    public static void BuildEditor()
    {
        //设置打包选项相关
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        //加入的场景
        buildPlayerOptions.scenes = new[] { "Assets/Boot.unity"};
        //windows中指定某文件夹及其中exe的名字
        buildPlayerOptions.locationPathName = "C:/UnityProjects/UnityTest";//Environment.GetCommandLineArgs().Last();
        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
