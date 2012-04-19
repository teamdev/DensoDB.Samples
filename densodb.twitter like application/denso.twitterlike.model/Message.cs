using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace denso.twitterlike.model
{
  public class Message
  {
    public DateTime Date { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public string Body { get; set; }
  }
}
