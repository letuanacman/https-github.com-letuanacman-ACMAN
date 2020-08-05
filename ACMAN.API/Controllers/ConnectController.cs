using ACMAN.API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Web;

namespace ACMAN.API.Controllers
{
    public class ConnectController
    {
        //MasterEntities mdb = new MasterEntities();
        //private ConnectStringInfo GetConnectString(string Tendata)
        //{
        //    try
        //    {
        //        var bussinessItem = mdb.SERVER_ONLINE.FirstOrDefault(x => x.TEN_DATA.Equals(Tendata));
        //        //var bussinessItem = (from p in mdb.SERVER_ONLINE
        //        //               join c in mdb.SERVER_ONLINE_PASS
        //        //               on p.ID equals c.ID_SERVER
        //        //               where p.TEN_DATA.Equals(Tendata)
        //        //               select new
        //        //               {
        //        //                   ID=p.ID,
        //        //                   SERVER = p.SERVER,
        //        //                   TEN_DATA = p.TEN_DATA,
        //        //                   USER_NAME = c.USER_NAME,
        //        //                   PASSWORD = c.PASSWORD 
        //        //               }).First();
        //        if (bussinessItem == null)
        //        {
        //            return null;
        //        }
        //        var entityConnectionStringBuilder = new EntityConnectionStringBuilder();
        //        entityConnectionStringBuilder.Provider = "System.Data.SqlClient";
        //        entityConnectionStringBuilder.ProviderConnectionString = @"Data Source=" + bussinessItem.SERVER + "; Initial Catalog=" +
        //                                                                 bussinessItem.TEN_DATA +
        //                                                                 ";Integrated Security=False;User Id=" + bussinessItem.USER_NAME + ";Password=" + bussinessItem.PASSWORD + ";MultipleActiveResultSets=True;;App=EntityFramework&quot;";
        //        entityConnectionStringBuilder.Metadata = "res://*";

        //        var bussinessInfo = new ConnectStringInfo
        //        {
        //            connectionString = entityConnectionStringBuilder.ToString(),
        //            DNID = bussinessItem.ID
        //        };
        //        return bussinessInfo;
        //    }

        //    catch (Exception)
        //    {

        //        return null;
        //    }

        //}

    }
}