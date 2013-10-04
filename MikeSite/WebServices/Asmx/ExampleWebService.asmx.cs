using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;

namespace MikeSite.WebServices.Asmx
{
    using MikeSite.Models.Examples;

    /// <summary>
    /// Summary description for ExampleWebService
    /// </summary>
    [WebService(Namespace = "http://miguelerm.azurewebsites.net/webservices/asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class ExampleWebService : WebService
    {

        [WebMethod]
        public OranizationalUnit[] GetOrganizationalUnits()
        {
            return new []
            {
                new OranizationalUnit { Id = 1, Name = "IT"},
                new OranizationalUnit { Id = 1, Name = "Marketing"},
                new OranizationalUnit { Id = 1, Name = "Sales"}

            };
        }
    }
}
