using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ACMAN.API.Extentions;
using ACMAN.API.Models;

namespace ACMAN.API.Controllers
{
    public class GetDoanhNghiepController : ApiController
    {
        private MasterDbcontext mdb = new MasterDbcontext();
        [Route("api/logindata")]
        [HttpPost]
        public LoginDataUser GetConnectString(LoginDataUser LoginClient)
        {
            //string Tendata = "ACMAN_DOANHNGHIEP";
            //string Username = "ADMIN";
            //string Matkhau = "1";
            string x1 = "";
            try
            {
                var bussinessItem = mdb.SERVER_ONLINE.FirstOrDefault(x => x.TEN_DATA.Equals(LoginClient.TenData));
                if (bussinessItem == null)
                {
                    return null;
                }
                var entityConnectionStringBuilder = new EntityConnectionStringBuilder();
                entityConnectionStringBuilder.Provider = "System.Data.SqlClient";
                entityConnectionStringBuilder.ProviderConnectionString = @"Data Source=" + bussinessItem.SERVER + "; Initial Catalog=" +
                                                                         bussinessItem.TEN_DATA +
                                                                         ";Integrated Security=False;User Id=" + bussinessItem.USER_NAME + ";Password=" + bussinessItem.PASSWORD + ";MultipleActiveResultSets=True;;App=EntityFramework&quot;";
                //entityConnectionStringBuilder.Metadata = "res://*";
                entityConnectionStringBuilder.Metadata = "res://*";//  /Models.DoanhNghiepModel.csdl|res://*/Models.DoanhNghiepModel.ssdl|res://*/Models.DoanhNghiepModel.msl";
                var bussinessInfo = new ConnectStringInfo
                {
                    connectionString = entityConnectionStringBuilder.ToString(),
                    DNID = bussinessItem.ID
                };
                var DNdb = new DoanhNghiepDbcontext(bussinessInfo.connectionString);
                var DnItem = DNdb.USER_LIST.FirstOrDefault(x => x.USER_NAME.Equals(LoginClient.Username) && x.PASSWORD.Equals(LoginClient.Password));
                if (DnItem == null)
                {
                    return null;
                }
                var Login1 = new LoginDoanhNghiepModel
                {
                    So_User = (int)bussinessItem.SOLUONG_USER,
                    FullName = DnItem.HO_TEN,
                    UserName = DnItem.USER_NAME
                };
                return LoginClient;
            }

            catch (Exception ex)
            {
                x1 = ex.ToString();
                return null;
            }

        }


    }
}