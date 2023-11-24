using System;
using System.Collections.Generic;
using System.Configuration;
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
    }
}
