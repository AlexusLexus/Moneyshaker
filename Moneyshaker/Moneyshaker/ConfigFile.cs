using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneyshaker
{
    class ConfigFile
    {
        public ConfigFile() { }

        public ConfigFile(string Name)
        {
            OSFileName = Name;
        }

        // Имя файла (например: Groups)
        public string FileName = "";
        // Путь к файлу (например: F:\Moneyshaker\Releases\Groups.ini)
        public string OSFileName;

        public void ReadFile() { }
    }

    class GroupConfigFile : ConfigFile
    {

    }
}
