using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public class SmartPhoneApp : List<Post>
    {
        public string? SmartPhoneId { get; set; }

        public new void Add(Post p)
        {
            if (p != null)
            {
                base.Add(p);
            }
        }

        public SmartPhoneApp(string smartphone)
        {
            SmartPhoneId = smartphone;
        }

        public string ProcessPosts()
        {
            string sus = "";
            foreach (Post p in this)
            {
                sus += p.ToString();
            }
            return sus;
        }

        public int CalcRating()
        {
            int rating = 0;
            foreach (Post p in this)
            {
                rating += p.Rating;
            }

            return rating;
        }

        public Post? this[string title]
        {
            get
            {
                return this.FindAll(x => x.HTML == title).Count != 0 ? this.FindAll(x => x.HTML == title)[0] : null;
            }
        }
    }
}
