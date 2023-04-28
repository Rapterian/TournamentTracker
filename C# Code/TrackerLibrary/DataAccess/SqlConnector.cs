using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;



namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {

        private const string db = "Tournaments";
        /// <summary>
        /// Saves a new person to the database
        /// </summary>
        /// <param name="personModel">the persons information</param>
        /// <returns>the persons information including the ID</returns>
        public PersonModel CreatePerson(PersonModel personModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", personModel.FirstName);
                p.Add("@LastName", personModel.LastName);
                p.Add("@EmailAddress", personModel.EmailAddres);
                p.Add("@CellphoneNumber", personModel.CellphoneNumber);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                personModel.ID = p.Get<int>("@ID");

                return personModel;
            }
        }

        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="prizeModel">the prize information</param>
        /// <returns>the prize information including the ID</returns>
        public PrizeModel CreatePrize(PrizeModel prizeModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber",prizeModel.PlaceNumber);
                p.Add("@PlaceName", prizeModel.PlaceName);
                p.Add("@PrizeAmount", prizeModel.PrizeAmount);
                p.Add("@PrizePercentage", prizeModel.PrizePercentage);
                p.Add("@ID",0,dbType:DbType.Int32,direction:ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                prizeModel.ID = p.Get<int>("@ID");

                return prizeModel;
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;  
        }

    }
}
