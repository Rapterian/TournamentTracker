using System;
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

        
        /// <summary>
        /// Saves a new person to the text file
        /// </summary>
        /// <param name="personModel"></param>
        /// <returns>the person information including the ID</returns>
        public void CreatePerson(PersonModel personModel)
        {
            // Load textFile and Covert text -> List<Prizemodel>
            List<PersonModel> people = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();

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
            people.SaveToPersonFile();

            
        }

        /// <summary>
        /// Saves a new prize to the text file
        /// </summary>
        /// <param name="prizeModel">the prize information</param>
        /// <returns>the prize information including the ID</returns>
        public void CreatePrize(PrizeModel prizeModel)
        {
            // Load textFile and Covert text -> List<Prizemodel>
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

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
            prizes.SaveToPrizeFile();

            
        }
        /// <summary>
        /// Saves a new team to the text file
        /// </summary>
        /// <param name="teamModel"></param>
        /// <returns>the team information including the ID</returns>
        public void CreateTeam(TeamModel teamModel)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();

            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.ID).First().ID + 1;
            }
            teamModel.ID = currentId;
            teams.Add(teamModel);

            teams.SaveToTeamFile();

            
        }

        public void CreateTournament(TournamentModel tournamentModel)
        {
            List<TournamentModel> tournaments =
                GlobalConfig.TournamentFile.
                FullFilePath().LoadFile().
                ConvertToTournamentModels();

            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.ID).First().ID + 1;
            }

            tournamentModel.ID = currentId;

            tournamentModel.SaveRoundsToFile();
            
            tournaments.Add(tournamentModel);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(tournamentModel);
        }

        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();
        }

        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
        }

        public void UpdateMatchup(MatchupModel matchupModel)
        {
            matchupModel.UpdateMatchupToFile();
        }
    }
}
