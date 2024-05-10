using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;


namespace TrackerLibrary.DataAccess.TextHelpers
{
    /// <summary>
    /// Has methods to easilly save data into a textfile
    /// </summary>
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// Takes filename and gives full filepath
        /// </summary>
        /// <param name="fileName">Name of file</param>
        /// <returns>Filepath</returns>
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        /// <summary>
        /// Takes a file with data on and puts it into a list of strings
        /// </summary>
        /// <param name="file">Filepath</param>
        /// <returns>List of strings</returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadLines(file).ToList();
        }

        /// <summary>
        /// converts list of strings to list of prizes
        /// </summary>
        /// <param name="lines">list of strings</param>
        /// <returns>list of prizeModels</returns>
        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();  

            foreach(string line in lines)
            {
                string[] cols = line.Split(';');

                PrizeModel p=new PrizeModel();  
                p.ID=int.Parse(cols[0]);
                p.PlaceNumber=int.Parse(cols[1]);
                p.PlaceName=cols[2];
                p.PrizeAmount=decimal.Parse(cols[3]);
                p.PrizePercentage=decimal.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }

        /// <summary>
        /// converts list of strings to list of people
        /// </summary>
        /// <param name="lines">list of strings</param>
        /// <returns>list of prizeModels</returns>
        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(';');

                PersonModel p = new PersonModel();
                p.ID = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddres = cols[3];
                p.CellphoneNumber = cols[4];

                output.Add(p);
            }

            return output;
        }
        /// <summary>
        /// converts list of strings to list of teams
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="peopleFileName"></param>
        /// <returns>list of TeamModel</returns>
        public static List<TeamModel> ConvertToTeamModel(this List<string> lines, string peopleFileName)
        {
            //id,team name,list of ids seperated by the pipe
            //3,A Team,1|3|5
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModel();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.ID = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach(string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.ID == int.Parse(id)).First());
                }

                output.Add(t);
            }

            return output;
        } 
        
        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines,string teamFileName,string PeopleFile,string prizesFile)
        {
            //id,TournamentName,EntryFee,(id|id|id - Entered Teams),(id|id|id - Prizes),(Rounds - id^id^id|id^id^id|id^id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFile);
            List<PrizeModel> prizes = prizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.ID = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                if (decimal.TryParse(cols[2], out decimal fee))
                {
                    tm.EntryFee = fee;
                }
                else
                {
                    tm.EntryFee = 0;
                }

                string[] teamIds = cols[3].Split('|');

                foreach(string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.ID == int.Parse(id)).First());
                }


                if (cols[4].Length>0)
                {
                    string[] prizeIds = cols[4].Split('|');

                    foreach (string id in prizeIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.ID == int.Parse(id)).First());
                    }  
                }

                //Capture Rounds information
                string[] rounds = cols[5].Split('|');
                List<MatchupModel> ms = new List<MatchupModel>();

                foreach(string round in rounds)
                {
                    string[] msText = round.Split("^");
                    
                    foreach(string matchupModelTextId in msText)
                    {
                        ms.Add(matchups.Where(x => x.ID == int.Parse(matchupModelTextId)).First());
                    }

                    tm.Rounds.Add(ms);
                }

                output.Add(tm);
            }

            return output;
        }

        /// <summary>
        /// converts list of prizemodels to list of strings and saves it to file specified
        /// </summary>
        /// <param name="prizeModels">list of prize models</param>
        /// <param name="fileName">file name</param>
        public static void SaveToPrizeFile(this List<PrizeModel> prizeModels,string fileName)
        {
            List<string> lines = new List<string>();

            foreach(PrizeModel p in prizeModels)
            {
                lines.Add($"{p.ID};{p.PlaceNumber};{p.PlaceName};{p.PrizeAmount};{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        /// <summary>
        /// converts list of person models to list of strings and saves it to file specified
        /// </summary>
        /// <param name="personModels">list of person models</param>
        /// <param name="fileName">file name</param>
        public static void SaveToPersonFile(this List<PersonModel> personModels, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in personModels)
            {
                lines.Add($"{p.ID};{p.FirstName};{p.LastName};{p.EmailAddres};{p.CellphoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        /// <summary>
        /// cinverts list of team models to list of strings and saves it to file specified
        /// </summary>
        /// <param name="teamModels"></param>
        /// <param name="fileName"></param>
        public static void SaveToTeamFile(this List<TeamModel> teamModels, string fileName)
        {
            List<string> lines = new List<string>();

            //id,team name,list of ids seperated by the pipe
            foreach(TeamModel t in teamModels)
            {
                lines.Add($"{t.ID},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveRoundsToFile(this TournamentModel model, string matchupFile, string matchupEntryFile)
        {
            // Loop through each round
            // Loop through each matchup
            // Get the id for the new matchup and save the record
            // Loop through each entry, get the id and save it

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    // Load all of the matchups from file
                    // Get the top id and add one
                    // Store the id
                    // Save the matchup record
                    matchup.SaveMatchupToFile();
                }
            }
        }

        public static void SaveMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 1;
            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.ID).First().ID + 1;
            }

            matchup.ID = currentId;
            //matchups.Add(matchup;

            matchups.Add(matchup);

            // Save to file
            List<string> lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.ID.ToString();
                }
                lines.Add($"{m.ID},{""},{winner},{m.MatchupRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);

            // id = 0, entries = 1(pipe delimited by id), winner = 2, matchupRound = 3
            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }

            // Save to file
            lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.ID.ToString();
                }
                lines.Add($"{m.ID},{ConvertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);

        }

        private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> entries)
        {
            string output = "";

            if (entries.Count == 0)
            {
                return "";
            }

            foreach (MatchupEntryModel e in entries)
            {
                output += $"{e.ID}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static void SaveEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int currentId = 1;
            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.ID).First().ID + 1;
            }

            entry.ID = currentId;
            entries.Add(entry);

            List<string> lines = new List<string>();

            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.ID.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.ID.ToString();
                }
                lines.Add($"{e.ID},{teamCompeting},{e.Score},{parent}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupModel p = new MatchupModel();
                p.ID = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                if (cols[2].Length == 0)
                {
                    p.Winner = null;
                }
                else
                {
                    p.Winner = LookupTeamById(int.Parse(cols[2]));
                }
                p.MatchupRound = int.Parse(cols[3]);

                output.Add(p);
            }

            return output;
        }

        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');

                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }   
            }

            output = matchingEntries.ConvertToMatchupEntryModels();

            return output;
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> input)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            
            foreach (string line in input)
            {
                string[] cols = line.Split(',');

                MatchupEntryModel me = new MatchupEntryModel();
                me.ID = int.Parse(cols[0]);
                if (cols[1].Length == 0)
                {
                    me.TeamCompeting = null;
                }
                else
                {
                    me.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                }
                me.Score = double.Parse(cols[2]);
                
                if (cols[3].Length <= 0)
                {
                    me.ParentMatchup = null;
                }
                else
                { 
                    me.ParentMatchup = LookupMatchupById(int.Parse(cols[3]));
                }

                output.Add(me);
            }  
            
            return output;
        }

        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');

                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }
            return null;
            
        }
        public static void SaveToTournamentFile(this List<TournamentModel> tournamentModels, string fileName)
        {
            List<string> lines = new List<string>();

            //id,team name,list of ids seperated by the pipe
            foreach (TournamentModel tm in tournamentModels)
            {
                lines.Add($"{tm.ID},{tm.TournamentName},{ tm.EntryFee.ToString("0.00", CultureInfo.InvariantCulture)},{ConvertTeamListToString(tm.EnteredTeams)},{ConvertPrizeListToString(tm.Prizes)},{ConvertRoundListToString(tm.Rounds)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');

                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModel(GlobalConfig.PersonFile).First();
                }
            }

            return null;
        }

        /// <summary>
        /// creates a string of all the IDs of the people in the team
        /// </summary>
        /// <param name="people"></param>
        /// <returns>string of IDs</returns>
        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            //if there are no people in the team return empty string
            if(people.Count==0)
            {
                return "";
            }

            //add all the IDs to the string
            foreach(PersonModel p in people)
            {
                output += $"{p.ID}|";
            }

            //taking of the last pipe
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            //if there are no people in the team return empty string
            if (teams.Count == 0)
            {
                return "";
            }

            //add all the IDs to the string
            foreach (TeamModel t in teams)
            {
                output += $"{t.ID}|";
            }

            //taking of the last pipe
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            //if there are no people in the team return empty string
            if (prizes.Count == 0)
            {
                return "";
            }

            //add all the IDs to the string
            foreach (PrizeModel p in prizes)
            {
                output += $"{p.ID}|";
            }

            //taking of the last pipe
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            //if there are no people in the team return empty string
            if (rounds.Count == 0)
            {
                return "";
            }

            //add all the IDs to the string
            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchupListToString(r)}|";
            }

            //taking of the last pipe
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            //if there are no people in the team return empty string
            if (matchups.Count == 0)
            {
                return "";
            }

            //add all the IDs to the string
            foreach (MatchupModel m in matchups)
            {
                output += $"{m.ID}^";
            }

            //taking of the last pipe
            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
