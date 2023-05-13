using UnityEditor;
using UnityEngine;

namespace Grave.Tools.ProjectSetup.Editor
{
    public static class MainTools
    {
        private const string projectSetup = "Project Setup: ";
        
        [MenuItem("Tools/Setup/Crate Default Folders")]
        public static void CrateDefaultFolders()
        {
            
            Directories.CreateDirectories("_Project", "Import", "Plugins", "Third Party");
            Directories.CreateSubDirectories("_Project",
                                             "_Prefabs", "_ScriptableAssets", "_Scripts", "Animations", "Materials", "Scenes", "Settings", "Terrain");
            
            AssetDatabase.Refresh();
            Debug.Log(projectSetup + "Creating default folders!");
        }

        [MenuItem("Tools/Packages/Input System")]
        public static void AddNewInputSystem()
        {
            
            Packages.AddUnityPackage("inputsystem");
            Debug.Log(projectSetup + "Adding Input System!");
        }
        
        [MenuItem("Tools/Packages/Postprocessing")]
        public static void AddPostprocessing()
        {
            
            Packages.AddUnityPackage("postprocessing");
            Debug.Log(projectSetup + "Adding PostProcessing!");
        }
        
        [MenuItem("Tools/Packages/Cinemachine")]
        public static void AddCinemachine()
        {
            
            Packages.AddUnityPackage("cinemachine");
            Debug.Log(projectSetup + "Adding CineMachine!");
        }
        
        [MenuItem("Tools/Packages/HDRP")]
        public static void AddHdrp()
        {
            
            Packages.RemoveUnityPackage("render-pipelines.universal");
            Packages.AddUnityPackage("render-pipelines.high-definition");
            Debug.Log(projectSetup + "Transferring to HDRP!");
        }
        
        [MenuItem("Tools/Packages/URP")]
        public static void AddUrp()
        {
            
            Packages.RemoveUnityPackage("render-pipelines.high-definition");
            Packages.AddUnityPackage("render-pipelines.universal");
            Debug.Log(projectSetup + "Transferring to URP!");
        }
    }
}
