// ----------------------------------------------------------------------------
// <copyright file="ErrorViewModel.cs" company="Encora S.A">
//     COPYRIGHT(C) 2020, Encora S.A
// </copyright>
// <author>Johan Ospina Nuñez</author>
// <email>jospina@Encora.com.</email>
// <summary>Query Battery Element</summary>
// ----------------------------------------------------------------------------

namespace Avantica.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
