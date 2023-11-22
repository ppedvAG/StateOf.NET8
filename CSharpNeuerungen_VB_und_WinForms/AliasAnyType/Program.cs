using Dt = System.DateTime;  //alt: alias auf bekannten Typ
using Mahlzeit = (string Getränk, string Essen);//neu alias any Type


var heute = Dt.Now;  //alt: alias known Type


var frühstück = new Mahlzeit("Kaffee", "Müsli");

var mittag = new Mahlzeit("Cola", "Döner");
mittag.Getränk = "Fanta";

(string getränk, string essen) abendessen = new Mahlzeit("Bier", "Schnitzel");


