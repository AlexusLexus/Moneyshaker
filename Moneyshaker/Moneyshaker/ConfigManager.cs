using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneyshaker
{
    class ConfigManager
    {
        public void Initialize()
        {
            GroupConfigFile = new ConfigFile();
        }

        private ConfigFile GroupConfigFile;
    }
}
