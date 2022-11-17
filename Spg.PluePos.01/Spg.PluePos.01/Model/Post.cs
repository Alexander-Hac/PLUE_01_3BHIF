using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public abstract class Post
    {
        public string? Title { get; }

        public DateTime Created { get; }

        private int rating;

        public int Rating
        {
            get { return rating; }
            set { 
                if (value > 0 && value <= 5)
                {
                    rating = value;
                } else {
                    throw new ArgumentOutOfRangeException("Range muss zwischen 1 und 5 liegen!"); 
                }
            }
        }

        public abstract string HTML { get; }

        public SmartPhoneApp? SmartPhone { get; set; }

        public Post(string title, DateTime created)
        {
            Title = title ?? throw new ArgumentNullException("Titel war NULL!");
            Created = created;
        }

        public Post(string title) : this(title, DateTime.Now)
        {

        }

        public override string ToString()
        {
            return HTML;
        }




    }
}
