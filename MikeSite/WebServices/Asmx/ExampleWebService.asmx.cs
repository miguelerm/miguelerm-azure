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
        public OU[] GetOUs()
        {
            return new []
            {
                new OU { Id = 1, Name = "IT"},
                new OU { Id = 2, Name = "Marketing"},
                new OU { Id = 3, Name = "Sales"}

            };
        }
    }
}
