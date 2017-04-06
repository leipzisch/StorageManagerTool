using System.IO.IsolatedStorage;
using System.Collections.Generic;
using NLog;
using System;

namespace IsolatedStorageFileManager.Model
{
    public class DirectoryView
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        List<Directory> directories;
        List<File> files;
        public DirectoryView()
        {
            logger.Debug("ctor");
        }

        public void acquire(string path)
        {
            using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {
                try { 
                foreach (string name in isoStore.GetDirectoryNames(path))
                {
                    logger.Trace(name);
                }
                }catch(Exception e)
                {
                    logger.Fatal(e.Message);
                }

                if (!isoStore.DirectoryExists(path))
                {

                }
            }
        }
        
    }
}
