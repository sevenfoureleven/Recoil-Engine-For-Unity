using UnityEditor;
using UnityEngine;

public class OpenDocumentationEditor : EditorWindow
{
    private const string githubURL = "https://github.com/TheToolmansCoffee/RecoilEngineVariables";

    [MenuItem("Recoil Engine/Documentation/Open Github")]
    private static void OpenGitHubPage()
    {
        Application.OpenURL(githubURL);
    }
}
