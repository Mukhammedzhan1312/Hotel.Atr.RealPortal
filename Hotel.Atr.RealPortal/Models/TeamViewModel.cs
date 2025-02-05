using System;

namespace Hotel.Atr.RealPortal.Models
{
    public class TeamViewModel
    {

        public string PathImage { get; set; }

        public string Description { get; set; }
        public string FullMaName { get; set; }
        public string Position { get; set; }
        public List<TeamLimks> TeamLimks { get; set; }
        //public List<Ahref> Ahref { get; set; }

    }
    public class TeamLimks
    {
        public string Link { get; set; }
        public string LinkType { get; set; }
    }

//    public class Ahref
//    {
//        public string href { get; set; }
//        public string PathClientImage { get; set;}
//}

}
//< div class= "col-md-4 col-sm-4" >
//               < div class= "single-team" >
//                   < div class= "team-image" >< img src = "img/team/1.jpg" alt = "" ></ div >
//                   < div class= "team-hover" >
//                       < h4 > Kathy Luis </ h4 >
//                       < span class= "block" > (Officer) </ span >
//                       < p > Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse</p>
//                       <div class= "team-links" >
//                           < a href = "https://www.facebook.com/" >< i class= "zmdi zmdi-facebook" ></ i ></ a >
//                           < a href = "https://twitter.com/" >< i class= "zmdi zmdi-twitter" ></ i ></ a >
//                           < a href = "https://www.pinterest.com/" >< i class= "zmdi zmdi-pinterest" ></ i ></ a >
//                       </ div >
//                   </ div >
//               </ div >