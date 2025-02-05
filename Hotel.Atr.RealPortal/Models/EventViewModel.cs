using System.Drawing;

namespace Hotel.Atr.RealPortal.Models
{
    public class EventViewModel
    {
        public int ImageSize { get; set; } 
        public string PathImage { get; set; }
        public string EventTitle { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }

    }
}

//< div class= "single-event col-md-8 col-sm-8 col-xs-12 conference" >
//                < div class= "single-event-item" >
//                    < img src = "img/event/1.jpg" alt = "" >
//                    < div class= "event-text" >
//                        < h3 class= "event-title" > management conferences </ h3 >
//                        < h3 class= "author-name" > By : Jhtyg Hyuir</h3>
//                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt</p>
//                    </div>
//                </div>
//            </div>