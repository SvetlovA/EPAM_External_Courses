using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace Task2
{
    class Spy : IDisposable
    {
        private DirectoryInfo _dir;
        private DirectoryInfo _saves;
        private FileInfo _file;
        private FileSystemWatcher _watcher = new FileSystemWatcher();


        public DirectoryInfo Dir
        {
            get
            {
                return _dir;
            }
        }

        public Spy(string dir)
        {
            _dir = new DirectoryInfo(dir);
            _saves = new DirectoryInfo(Path.Combine(_dir.Parent.FullName, "Saves"));
            _file = new FileInfo(Path.Combine(_dir.Parent.FullName, @"Log\Logs.txt"));

            if (!_saves.Exists)
            {
                _saves.Create();
            }

            if (!_file.Exists)
            {
                _file.CreateText();
            }
        }

        /// <summary>
        /// Run spy for directory
        /// </summary>
        public void Run()
		{
//#error _watcher содержит системные ресурсы и требует вызова Dispose() после того как он уже не нужен
//#error иначе при аварийном выходе слежение за каталогом может продолжиться
            _watcher.IncludeSubdirectories = true;
            _watcher.Path = _dir.FullName;
            _watcher.Filter = "*.txt";

            _watcher.Changed += new FileSystemEventHandler(OnChanged);
            _watcher.Created += new FileSystemEventHandler(OnChanged);
            _watcher.Deleted += new FileSystemEventHandler(OnChanged);
            _watcher.Renamed += new RenamedEventHandler(OnRenamed);

            _watcher.EnableRaisingEvents = true;
        }

        /// <summary>
        /// Recover directory
        /// </summary>
        /// <param name="recoveryTime"> Time to recover</param>
        public void Recover(DateTime recoveryTime)
        {
            if (recoveryTime > DateTime.Now)
            {
                throw new Exception("Вы ввели дату болше сегодняшней!!!");
            }
            DeleteInDir(_dir);
            foreach (var directory in _saves.GetDirectories().Reverse())
            {
                if (directory.CreationTime <= recoveryTime)
                {
                    CopyDirs(directory, _dir);
                    break;
                }
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            _watcher.EnableRaisingEvents = false;
            using (StreamWriter sw = _file.AppendText())
            {
                sw.WriteLine("File " + e.Name + " was " + e.ChangeType);
            }

            Console.WriteLine("File " + e.Name + " was " + e.ChangeType);

            CopyDirs(_dir, new DirectoryInfo(Path.Combine(_saves.FullName, _dir.Name + " " + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour
                            + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond)));

            _watcher.EnableRaisingEvents = true;
//#error останавливаем основной поток на пол секунды это будет удар по производительности
//#error если что-то работает не как ожидалось, то следует устранить причину а не маскировать ее
        }

        /// <summary>
        /// Copy directoryes
        /// </summary>
        /// <param name="fromDir"> From directory</param>
        /// <param name="toDir"> To directory</param>
        private void CopyDirs(DirectoryInfo fromDir, DirectoryInfo toDir)
        {
            toDir.Create();
            foreach (var dir in fromDir.GetDirectories())
            {
                CopyDirs(dir, Directory.CreateDirectory(Path.Combine(toDir.FullName, dir.Name)));
            }
            foreach (var file in fromDir.GetFiles())
            {
                file.CopyTo(Path.Combine(toDir.FullName, file.Name));
            }
        }

        /// <summary>
        /// Delete directories
        /// </summary>
        /// <param name="toDir"> Directory for delete</param>
        private void DeleteInDir(DirectoryInfo toDir)
        {
            foreach (var file in toDir.GetFiles())
            {
                file.Delete();
            }
            foreach (var dir in toDir.GetDirectories())
            {
                DeleteInDir(dir);
                dir.Delete();
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            using (StreamWriter sw = _file.AppendText())
            {
                sw.WriteLine("File " + e.OldName + " was " + e.ChangeType + ". New name: " + e.Name);
            }
            Console.WriteLine("File " + e.OldName + " was " + e.ChangeType + ". New name: " + e.Name);

            CopyDirs(_dir, new DirectoryInfo(Path.Combine(_saves.FullName, _dir.Name + " " + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour
                            + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond)));
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            _watcher.Dispose();
        }
    }
}
