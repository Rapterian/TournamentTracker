﻿using Dapper;
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
        /// Saves a new tm to the database
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

        public TeamModel CreateTeam(TeamModel teamModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@teamName", teamModel.TeamName);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                teamModel.ID = p.Get<int>("@ID");

                foreach(PersonModel tm in teamModel.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@teamID", teamModel.ID);
                    p.Add("@personID", tm.ID);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }

                return teamModel;
            }
        }

        public void CreateTournament(TournamentModel tournamentModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                SaveTournament(tournamentModel,connection);

                SaveTournamentPrizes(tournamentModel,connection);

                SaveTournamentEntries(tournamentModel, connection);
                
                SaveTournamentRounds(tournamentModel, connection);

            }
        }

        private void SaveTournamentRounds(TournamentModel tournamentModel, IDbConnection connection)
        {
            // List<List<MatchupModel>> Rounds
            // List<MatchupEntryModel> Entries
            // List<TeamModel> Teams

            // Loop through the rounds
            // Loop through the matchups
            // Save the matchup
            // Loop through the entries
            // Save the entry

            foreach (List<MatchupModel> round in tournamentModel.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentID", tournamentModel.ID);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

                    matchup.ID = p.Get<int>("@ID");

                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupID", matchup.ID);

                        if (entry.ParentMatchup == null)
                        {
                            p.Add("@ParentMatchupID", null);
                        }
                        else
                        {
                            p.Add("@ParentMatchupID", entry.ParentMatchup.ID);
                        }

                        if (entry.TeamCompeting == null)
                        {
                            p.Add("@TeamCompetingID", null);
                        }
                        else
                        {
                            p.Add("@TeamCompetingID", entry.TeamCompeting.ID);
                        }

                        //p.Add("@Score", entry.Score);
                        p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }

        private void SaveTournament(TournamentModel tournamentModel, IDbConnection connection)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", tournamentModel.TournamentName);
            p.Add("@EntryFee", tournamentModel.EntryFee);
            p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

            tournamentModel.ID = p.Get<int>("@ID");
        }

        private void SaveTournamentPrizes(TournamentModel tournamentModel, IDbConnection connection)
        {
            foreach (PrizeModel pz in tournamentModel.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentID", tournamentModel.ID);
                p.Add("@PrizeID", pz.ID);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentEntries(TournamentModel tournamentModel, IDbConnection connection)
        {
            foreach (TeamModel tm in tournamentModel.EnteredTeams)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentID", tournamentModel.ID);
                p.Add("@TeamID", tm.ID);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
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

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeams_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@teamID", team.ID);

                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }
    }
}
