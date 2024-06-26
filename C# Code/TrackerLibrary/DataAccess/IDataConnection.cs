﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    /// <summary>
    /// Interface forcing us to implement all necesary methods to store all necesary information
    /// </summary>
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel prizeModel);
        PersonModel CreatePerson(PersonModel personModel);
        TeamModel CreateTeam(TeamModel teamModel);
        void  CreateTournament(TournamentModel tournamentModel);

        List<PersonModel> GetPerson_All();
        List<TeamModel> GetTeam_All();
        List<TournamentModel> GetTournament_All();
    }
}
