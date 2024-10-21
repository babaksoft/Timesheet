using System;
using System.IO;

namespace BabakSoft.Platform.Helpers
{
    /// <summary>
    /// Provides utility methods for working with files and folders
    /// </summary>
    public class FileUtility
    {
        /// <summary>
        /// Converts a relative path to the equivalent absolute path, using a specific folder
        /// </summary>
        /// <param name="relativePath">Relative path to convert</param>
        /// <param name="relativeToPath">A path that source path is relative to. If not specified,
        /// source path is considered to be relative to current directory.
        /// <returns>The absolute path converted from the given relative path</returns>
        public static string GetAbsolutePath(string relativePath, string relativeToPath = null)
        {
            var absolutePath = relativeToPath ?? Environment.CurrentDirectory;
            var parts = relativePath.Split(Path.DirectorySeparatorChar);
            foreach (var part in parts)
            {
                if (part == "..")
                {
                    absolutePath = Path.GetDirectoryName(absolutePath);
                }
                else if (part != ".")
                {
                    absolutePath = Path.Combine(absolutePath, part);
                }
            }

            return absolutePath;
        }
    }
}
