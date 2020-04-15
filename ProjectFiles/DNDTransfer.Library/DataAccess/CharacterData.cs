﻿using DNDTransfer.Library.Internal.DataAccess;
using DNDTransfer.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDTransfer.Library.DataAccess
{
    public class CharacterData
    {
        public List<CharacterModel> GetCharacters(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = Id };
            //if I didnt have p I could use new { } (anon class object)
            var output = sql.LoadData<CharacterModel, dynamic>("dbo.spCharacter_GetAll", p, "DNDData");//pass in our stored procedure, parameters, and database string name

            return output;
        }
    }
}
