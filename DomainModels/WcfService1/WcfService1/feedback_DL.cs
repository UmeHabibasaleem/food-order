using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class feedback_DL
    {
        public static List<feedback> userfeed = new List<feedback>();

        public void userfeedback(feedback l)
        {
            userfeed.Add(l);
        }
    }
}