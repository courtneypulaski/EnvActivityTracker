using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class EnvironmentModel
    {
        public string EnvironmentCode { get; set; }

        public string EnvironmentName { get; set; }

        public string EnvironmentDetails { get; set; }

        public EnvironmentModel()
        {

        }

        public EnvironmentModel(string environmentCode, string environmentName, string environmentDetails)
        {
            EnvironmentCode = environmentCode;
            EnvironmentName = environmentName;
            EnvironmentDetails = environmentDetails;
        }

    }
}
