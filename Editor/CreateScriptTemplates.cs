using UnityEditor;

namespace Toolbox.ScriptTemplates
{
    public static class CreateScriptTemplates
    {
        private const string TemplateFolderPath = "Package/com.game5mobile.scripttemplate/Editor/Templates/";

        [MenuItem("Assets/Create/Script/Scene Singleton", priority = -1)]
        public static void CreateSceneSingleton()
        {
            string templatePath = TemplateFolderPath + "SceneSingleton.cs.txt";

            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewMonoController.cs");
        }

        [MenuItem("Assets/Create/Script/MonoBehaviour", priority = -1)]
        public static void CreateMonoBehaviour()
        {
            string templatePath = TemplateFolderPath + "MonoBehaviour.cs.txt";

            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewMonoBehaviour.cs");
        }

        [MenuItem("Assets/Create/Script/Scriptable Object", priority = -1)]
        public static void CreateScriptableObject()
        {
            string templatePath = TemplateFolderPath + "ScriptableObject.cs.txt";

            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewScriptableObjectSO.cs");
        }

        [MenuItem("Assets/Create/Script/Class", priority = -1)]
        public static void CreateClass()
        {
            string templatePath = TemplateFolderPath + "Class.cs.txt";

            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewClass.cs");
        }

        [MenuItem("Assets/Create/Script/Struct", priority = -1)]
        public static void CreateStruct()
        {
            string templatePath = TemplateFolderPath + "Struct.cs.txt";

            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewStruct.cs");
        }

        [MenuItem("Assets/Create/Script/Enum", priority = -1)]
        public static void CreateEnum()
        {
            string templatePath = TemplateFolderPath + "Enum.cs.txt";

            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewEnum.cs");
        }

        [MenuItem("Assets/Create/Script/Interface", priority = -1)]
        public static void CreateInterface()
        {
            string templatePath = TemplateFolderPath + "Interface.cs.txt";

            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewInterface.cs");
        }
    }
}
