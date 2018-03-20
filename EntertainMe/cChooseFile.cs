using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace fileSelector2
{
    class cChooseFile
    {
        private static Random rand = new Random();
        private static List<string> musicExt = new List<string>() {  "*.wav", "*.mp3", "*.wma" };
        private static List<string> videoExt = new List<string>() { "*.mp4", "*.wmv", "*.avi", "*.flv" };
        private static bool includeMusic = false;
        private static bool includeVideo = false;
        private static bool getSubDirectory = false;
        private static bool useAllSubFiles = false;
        private static bool checkTime = false;
        private static int subPercnt = 70;
        private static int allPercnt = 65;
        private static int minSec = 0;
        private static int maxSec = 0;

        /// <summary>
        /// Sets parameters for checking for timing filter
        /// </summary>
        /// <param name="minTime"></param>
        /// <param name="maxTime"></param>
        /// <param name="timeCheck"></param>
        /// <returns></returns>
        private static void setTiming(int minTime, int maxTime)
        {
            minSec = minTime;
            maxSec = maxTime;
        }

        /// <summary>
        /// used as entry point to return a list of strings
        /// which are paths to files within the directory in the parameter
        /// and may be video, audio, or both
        /// </summary>
        /// <param name="directory">the root directory for the files</param>
        /// <param name="fileType">either audio or video of extension types listed in the parameters</param>
        /// <param name="num">optional number of paths to return, if available, default is ten</param>
        /// <returns></returns>
        public static List<string> getFilesFromDirectory(string directory, string fileType, int minTime, int maxTime, bool timeCheck, int num = 10)
        {
            setTiming(minTime, maxTime);
            return getFilesFromDirectory(directory, fileType, timeCheck, num);
        }
        

        /// <summary>
        /// used as entry point to return a list of strings
        /// which are paths to files within the directory in the parameter
        /// and may be video, audio, or both
        /// </summary>
        /// <param name="directory">the root directory for the files</param>
        /// <param name="fileType">either audio or video of extension types listed in the parameters</param>
        /// <param name="num">optional number of paths to return, if available, default is ten</param>
        /// <returns></returns>
        public static List<string> getFilesFromDirectory(string directory, string fileType, bool timeCheck, int num = 10)
        {
            List<string> filesList = new List<string>();

            try
            {
                checkTime = timeCheck;

                if (fileType.ToLower() == "music" || fileType.ToLower() == "sound" || fileType.ToLower() == "audio")
                    includeMusic = true;
                else if (fileType.ToLower() == "video")
                    includeVideo = true;
                else if (fileType.ToLower() == "all")
                {
                    includeMusic = includeVideo = true;
                }
                else
                {
                    Console.WriteLine("Error: file type is not valid");
                    return null;
                }

                if (rand.Next(100) < allPercnt)
                {
                    useAllSubFiles = true;
                }
                else
                {
                    useAllSubFiles = false;
                    if (rand.Next(100) < subPercnt)
                    {
                        getSubDirectory = true;
                    }
                    else
                    {
                        getSubDirectory = false;
                    }
                }

                if (!Directory.Exists(directory))
                {
                    Console.WriteLine("That path does not exist.");
                    return null;
                }

                if(useAllSubFiles)
                {
                    filesList = getDirectoryFiles(directory);
                }
                else
                {
                    if(getSubDirectory)
                    {
                        List<string> directories = Directory.GetDirectories(directory, "*", SearchOption.AllDirectories).ToList();
                        directories.Add(directory);
                        Shuffle(directories);

                        int position = 0;

                        while (filesList.Count < num && position < directories.Count)
                        {
                            filesList.AddRange(getDirectoryFiles(directories[position++]));
                        }
                    }
                    else
                    {
                        filesList = getDirectoryFiles(directory);

                        if (filesList.Count < num)
                        {
                            List<string> directories = Directory.GetDirectories(directory, "*", SearchOption.AllDirectories).ToList();
                            Shuffle(directories);

                            int position = 0;

                            while (filesList.Count < num && position < directories.Count)
                            {
                                filesList.AddRange(getDirectoryFiles(directories[position++]));
                            }
                        }
                    }
                }

                Shuffle(filesList);

                if (filesList.Count > num)
                {
                    return filesList.GetRange(0, num);
                }
                else
                    return filesList;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
                return null;
            }
        }

        /// <summary>
        /// Returns a list of files found within a directory,
        /// results depend upon class boolean parameters
        /// these determine whether the files are from just the 
        /// given directory, or from all subfiles
        /// and also whether video or audio files are used - or both
        /// </summary>
        /// <param name="directory">directory to provide files</param>
        /// <returns>a list of path names for files found in the directory</returns>
        private static List<string> getDirectoryFiles(string directory)
        {
            List<string> filesList = new List<string>();
            SearchOption searchOption = SearchOption.TopDirectoryOnly;

            if (useAllSubFiles)
                searchOption = SearchOption.AllDirectories;

            try
            {
                if (!Directory.Exists(directory))
                {
                    Console.WriteLine("That path does not exist.");
                    return null;
                }

                if(includeMusic)
                {
                    foreach(string s in musicExt)
                    {
                        filesList.AddRange(Directory.GetFiles(directory, s, searchOption).ToList());
                    }
                }
                if(includeVideo)
                {
                    foreach (string s in videoExt)
                    {
                        filesList.AddRange(Directory.GetFiles(directory, s, searchOption).ToList());
                    }
                }
                if(checkTime)
                {
                    List<string> filesListTimed = new List<string>(); 
                    using (var engine = new Engine())
                    {
                        foreach (string sFile in filesList)
                        {

                            var inputFile = new MediaFile { Filename = sFile };
                            engine.GetMetadata(inputFile);
                            if (inputFile.Metadata.Duration.TotalSeconds >= minSec && inputFile.Metadata.Duration.TotalSeconds <= maxSec)
                            {
                                filesListTimed.Add(sFile);
                            }
                        }
                    }
                    return filesListTimed;
                }
                else
                    return filesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
                return null;
            } 
        }

        /// <summary>
        /// shuffles the list given in the parameter, randomizing the list order
        /// </summary>
        /// <param name="list">list of string values, in this case file paths for files or directories</param>
        private static void Shuffle(List<string> list)
        {
            if (list == null)
                return;
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(0, list.Count);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}