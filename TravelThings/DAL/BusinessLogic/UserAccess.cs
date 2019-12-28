﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelThings.Helpers;
using TravelThings.DAL.Interfaces;
using System.Data;
using System.Data.SqlClient;
//using System.Configuration;

namespace TravelThings.DAL.BusinessLogic
{
    internal class UserAccess : DataProcessing, IUserAccess
    {
        public string InsertUserDetails(string UserName, string PhoneNo)
        {
            SqlCommand cmd = new SqlCommand("usp_Insert_User_Details");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@User_Name", UserName);
            cmd.Parameters.AddWithValue("@Phone_No", PhoneNo);
            return Convert.ToString(ExecuteScalar(cmd));
        }
    }
}