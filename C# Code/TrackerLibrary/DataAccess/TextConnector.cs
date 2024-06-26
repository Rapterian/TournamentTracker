﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";
        private const string MatchupFile = "MatchupModels.csv";
        private const string MatchupEntryFile = "MatchupEntryModels.csv";
        /// <summary>
        /// Saves a new person to the text file
        /// </summary>
        /// <param name="personModel"></param>
        /// <returns>the person information including the ID</returns>
        public PersonModel CreatePerson(PersonModel personModel)
        {
            // Load textFile and Covert text -> List<Prizemodel>
            List<PersonModel> people = PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();

            // Find ID

            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.ID).First().ID + 1;
            }


            personModel.ID = currentId;

            // Add new record with new ID (Max+1)
            people.Add(personModel);

            // Convert Prizes -> List<string and Save List<string> to textFile
            people.SaveToPersonFile(PersonFile);

            return personModel;
        }

        /// <summary>
        /// Saves a new prize to the text file
        /// </summary>
        /// <param name="prizeModel">the prize information</param>
        /// <returns>the prize information including the ID</returns>
        public PrizeModel CreatePrize(PrizeModel prizeModel)
        {
            // Load textFile and Covert text -> List<Prizemodel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            // Find ID

            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId =prizes.OrderByDescending(x => x.ID).First().ID + 1;
            }


            prizeModel.ID = currentId;  

            // Add new record with new ID (Max+1)
            prizes.Add(prizeModel);

            // Convert Prizes -> List<string and Save List<string> to textFile
            prizes.SaveToPrizeFile(PrizesFile);

            return prizeModel;
        }
        /// <summary>
        /// Saves a new team to the text file
        /// </summary>
        /// <param name="teamModel"></param>
        /// <returns>the team information including the ID</returns>
        public TeamModel CreateTeam(TeamModel teamModel)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PersonFile);

            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.ID).First().ID + 1;
            }
            teamModel.ID = currentId;
            teams.Add(teamModel);

            teams.SaveToTeamFile(TeamFile);

            return teamModel;
        }

        public void CreateTournament(TournamentModel tournamentModel)
        {
            List<TournamentModel> tournaments = 
                TournamentFile.
                FullFilePath().LoadFile().
                ConvertToTournamentModels(TeamFile,PersonFile,PrizesFile);

            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.ID).First().ID + 1;
            }

            tournamentModel.ID = currentId;

            tournamentModel.SaveRoundsToFile(MatchupFile, MatchupEntryFile);
            
            tournaments.Add(tournamentModel);

            tournaments.SaveToTournamentFile(TournamentFile);

           
        }

        public List<PersonModel> GetPerson_All()
        {
            return PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PersonFile);
        }

        public List<TournamentModel> GetTournament_All()
        {
            return TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels(TeamFile, PersonFile, PrizesFile);
        }
    }
}
