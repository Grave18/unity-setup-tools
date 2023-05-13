namespace Grave.Tools.ProjectSetup.Editor
{
    public static class Packages
    {
        public static void AddUnityPackage(string packageName)
        {
            UnityEditor.PackageManager.Client.Add($"com.unity.{packageName}");
        }
        
        public static void RemoveUnityPackage(string packageName)
        {
            UnityEditor.PackageManager.Client.Remove($"com.unity.{packageName}");
        }
    }
}
