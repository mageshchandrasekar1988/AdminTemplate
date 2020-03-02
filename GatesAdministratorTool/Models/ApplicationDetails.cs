using System;
using System.Collections.Generic;

namespace GatesAdministratorTool.Models
{
    public partial class ApplicationDetails
    {
        public int ApplicationId { get; set; }
        public string DefaultUserLevel { get; set; }
        public string DatabaseExpireDate { get; set; }
        public string VersionMajor { get; set; }
        public string VersionBuild { get; set; }
        public string InstallLocation { get; set; }
        public string IsRequiredUpdate { get; set; }
        public string EmailRecipients { get; set; }
        public string AppSwitches { get; set; }
        public string DefaultLifetime { get; set; }
        public string DatabaseVersion { get; set; }
        public string VersionMinor { get; set; }
        public string VersionRevision { get; set; }
        public string UpdateDescriptionPath { get; set; }
        public string RequiredMinimumVersion { get; set; }
        public string EmailNotification { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
