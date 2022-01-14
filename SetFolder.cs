using UnityEditor;
using System.IO;

public class SetFolder
{
    [MenuItem("Custom/CreateFolder")]
    static void CreateFolder()
    {
        if(AssetDatabase.IsValidFolder("Assets/"))
        {
            return;
        }
        FloderName("Animations");
        FloderName("AnimatorControllers");
        FloderName("Textures");
        FloderName("Materials");
        FloderName("Prefabs");
        FloderName("Scripts");
        FloderName("sounds");
        FloderName("texture");
        
    }

    static void FloderName(string name)
    {
        string path = "Assets/" + name;

        if(!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        AssetDatabase.ImportAsset(path);
    }

}
