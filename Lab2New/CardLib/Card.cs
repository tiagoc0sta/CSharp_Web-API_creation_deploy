using System;
using System.Collections.Generic;
using System.Web;

public class Card : ICloneable
{
   
    public string imageLink;    
    public static bool isAceHigh = true;

    public Card() { }
    
    public object Clone() { return MemberwiseClone(); }
    
}
