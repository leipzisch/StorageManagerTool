using System;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolatedStorageFileManager.Model
{
    public class DirectoryView
    {
        List<Directory> directories;
        List<File> files;
        public DirectoryView()
        {
            
        }

        void acquire(string path)
        {
            using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (!isoStore.DirectoryExists(TransfersFolder))
                {
                    isoStore.CreateDirectory(TransfersFolder);
                }
            }
        }
        
    }
}
