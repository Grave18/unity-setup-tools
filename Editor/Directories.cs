using System.IO;
using UnityEngine;

namespace Grave.Tools.ProjectSetup.Editor
{
    public static class Directories
    {
        public static void CreateSubDirectories(string root, params string[] directories)
        {
            string fullPath = Path.Combine(Application.dataPath, root);

            foreach (string directory in directories)
            {
                UnityEngine.Windows.Directory.CreateDirectory(Path.Combine(fullPath, directory));
            }
        }
        public static void CreateDirectories(params string[] directories)
        {
            foreach (string directory in directories)
            {
                UnityEngine.Windows.Directory.CreateDirectory(Path.Combine(Application.dataPath, directory));
            }
        }
    }
}
