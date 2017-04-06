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

        public void acquire(string patt)
        {
            using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {
                try
                {
                    foreach (string dname in isoStore.GetDirectoryNames(patt))
                    {
                        logger.Trace(dname);
                    }
                    foreach (string fname in isoStore.GetFileNames(patt))
                    {
                        logger.Trace(fname);
                    }
                }
                catch (Exception e)
                {
                    logger.Fatal(e.Message);
                }

                if (!isoStore.DirectoryExists(patt))
                {

                }
            }
        }

    }
}
