using Hotel.Atr.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Atr.RealPortal.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            //#region Get data from DataBase
            List<TeamViewModel> teams = new List<TeamViewModel>();
            TeamViewModel team = new TeamViewModel();
            team.FullMaName = "John Doe";
            team.Position = "CEO";
            team.Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt";
            team.PathImage = "~/img/team/1.jpg";
            team.TeamLimks = new List<TeamLimks>()
            {
                new TeamLimks { Link = "https://www.facebook.com/", LinkType = "zmdi zmdi-facebook" },
                new TeamLimks { Link = "https://twitter.com/", LinkType = "zmdi zmdi-twitter" },
                new TeamLimks { Link = "https://www.pinterest.com/", LinkType = "zmdi zmdi-pinterest" }
            };
            //team.Ahref = new List<Ahref>()
            //{
            //    new Ahref { href = "vcrf",PathClientImage = "ffcf"},
            //    new Ahref { href = "vcrf",PathClientImage = "ffcf"},
            //    new Ahref { href = "vcrf",PathClientImage = "ffcf"}
            //};

            teams.Add(team);

            //teams.Add(new TeamViewModel
            //{
            //    FullMaName = "John Doe",
            //    Position = "CEO",
            //    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt",
            //    PathImage = "~/img/team/1.jpg",
            //    TeamLimks = new List<TeamLimks>() 
            //    {

            //    new TeamLimks { Link = "https://www.facebook.com/", LinkType = "zmdi zmdi-facebook" },
            //    new TeamLimks { Link = "https://twitter.com/", LinkType = "zmdi zmdi-twitter" },
            //    new TeamLimks { Link = "https://www.pinterest.com/", LinkType = "zmdi zmdi-pinterest" }
            //    }
            //});

            
            return View(teams);

        }
    }
}
