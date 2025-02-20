using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FileExercise
{
    // Custom exception
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {

        }
    }

    class FileManager
    {
        private string filePath;

        // Constructor
        public FileManager()
        {
            filePath = string.Empty;
        }

        // Constructor
        public FileManager(string filePath)
        {
            this.filePath = filePath;
          
        }

        public string ReadWords()
        {
            string content = string.Empty;

            content = ReadFile();

            return content;
        }

        /* Method reads file from a local 
         * directory path.
         */
        private string ReadFile()
        {
            if (!File.Exists(filePath))
            {
                // Throw custom exception if file does not exist
                throw new WordListNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
            return fileContent;
        }
    }
}