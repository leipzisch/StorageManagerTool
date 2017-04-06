using System.IO.IsolatedStorage;
using System.Collections.Generic;
using NLog;

namespace IsolatedStorageFileManager.Model
{
    public class DirectoryView
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        List<Directory> directories;
        List<File> files;
        public DirectoryView()
        {
            
        }

        void acquire(string path)
        {
            using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (!isoStore.DirectoryExists(path))
                {

                }
            }
        }
        
    }
}
