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
    }
}
