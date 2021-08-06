// ========================================================
// CountySeedData.cs, 210318
// Author: Russell Fisher
// County objects are primarily used in Location objects
//  
// ========================================================


using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using SHTWIMS03.Models;


namespace SHTWIMS03.Areas.Locate.Models
{
    public class CountySeedData // ----------------------------------------------------------------
    {
        public static void EnsurePopulated(IApplicationBuilder app) // ----------------------------
        {

            County junk = new County();

            ApplicationDbContext context = app.ApplicationServices.
                GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Counties.Any())
            {
                context.Counties.AddRange(

                    new County { CntyFIPS = "005", CntyName = "Angelina", Territory = "DPEST", Seat = "Lufkin", SeatLat = 31.34223, SeatLon = -94.71815, Area = 865 },
                    new County { CntyFIPS = "007", CntyName = "Aransas", Territory = "CSBND", Seat = "Rockport", SeatLat = 28.03227, SeatLon = -97.06592, Area = 528 },
                    new County { CntyFIPS = "015", CntyName = "Austin", Territory = "INLD", Seat = "Bellville", SeatLat = 29.95101, SeatLon = -96.25742, Area = 656 },
                    new County { CntyFIPS = "025", CntyName = "Bee", Territory = "CXRD", Seat = "Beeville", SeatLat = 28.40242, SeatLon = -97.74932, Area = 880 },
                    new County { CntyFIPS = "039", CntyName = "Brazoria", Territory = "INLD", Seat = "Angleton", SeatLat = 29.16466, SeatLon = -95.4325, Area = 1609 },
                    new County { CntyFIPS = "041", CntyName = "Brazos", Territory = "OTHER", Seat = "Bryan", SeatLat = 30.67009, SeatLon = -96.37083, Area = 591 },
                    new County { CntyFIPS = "047", CntyName = "Brooks", Territory = "CSBND", Seat = "Falfurrias", SeatLat = 27.22832, SeatLon = -98.14401, Area = 944 },
                    new County { CntyFIPS = "051", CntyName = "Burleson", Territory = "OTHER", Seat = "Caldwell", SeatLat = 30.53276, SeatLon = -96.69355, Area = 677 },
                    new County { CntyFIPS = "057", CntyName = "Calhoun", Territory = "CXRD", Seat = "Port Lavaca", SeatLat = 28.61599, SeatLon = -96.62359, Area = 1033 },
                    new County { CntyFIPS = "061", CntyName = "Cameron", Territory = "STEX", Seat = "Brownsville", SeatLat = 25.89998, SeatLon = -97.48505, Area = 1276 },
                    new County { CntyFIPS = "071", CntyName = "Chambers", Territory = "CNCST", Seat = "Anahuac", SeatLat = 29.77328, SeatLon = -94.6822, Area = 871 },
                    new County { CntyFIPS = "089", CntyName = "Colorado", Territory = "INLD", Seat = "Columbus", SeatLat = 29.70678, SeatLon = -96.54647, Area = 974 },
                    new County { CntyFIPS = "123", CntyName = "DeWitt", Territory = "CXRD", Seat = "Cuero", SeatLat = 29.09298, SeatLon = -97.28719, Area = 910 },
                    new County { CntyFIPS = "131", CntyName = "Duval", Territory = "CSBND", Seat = "San Diego", SeatLat = 27.76451, SeatLon = -98.23959, Area = 1796 },
                    new County { CntyFIPS = "157", CntyName = "Fort Bend", Territory = "INLD", Seat = "Richmond", SeatLat = 29.58289, SeatLon = -95.76116, Area = 885 },
                    new County { CntyFIPS = "167", CntyName = "Galveston", Territory = "CNCST", Seat = "Galveston", SeatLat = 29.29522, SeatLon = -94.80791, Area = 874 },
                    new County { CntyFIPS = "175", CntyName = "Goliad", Territory = "CXRD", Seat = "Goliad", SeatLat = 28.66848, SeatLon = -97.38913, Area = 859 },
                    new County { CntyFIPS = "177", CntyName = "Gonzales", Territory = "OTHER", Seat = "Gonzales", SeatLat = 29.50007, SeatLon = -97.45206, Area = 1070 },
                    new County { CntyFIPS = "185", CntyName = "Grimes", Territory = "OTHER", Seat = "Anderson", SeatLat = 30.48815, SeatLon = -95.98674, Area = 802 },
                    new County { CntyFIPS = "199", CntyName = "Hardin", Territory = "NCST", Seat = "Kountze", SeatLat = 30.37611, SeatLon = -94.31415, Area = 898 },
                    new County { CntyFIPS = "201", CntyName = "Harris", Territory = "HRCTY", Seat = "Houston", SeatLat = 29.76063, SeatLon = -95.36975, Area = 1778 },
                    new County { CntyFIPS = "215", CntyName = "Hidalgo", Territory = "STEX", Seat = "Edinburg", SeatLat = 26.30112, SeatLon = -98.16089, Area = 1583 },
                    new County { CntyFIPS = "225", CntyName = "Houston", Territory = "DPEST", Seat = "Crockett", SeatLat = 31.31846, SeatLon = -95.45805, Area = 1237 },
                    new County { CntyFIPS = "239", CntyName = "Jackson", Territory = "CXRD", Seat = "Edna", SeatLat = 28.97849, SeatLon = -96.64618, Area = 857 },
                    new County { CntyFIPS = "241", CntyName = "Jasper", Territory = "NCST", Seat = "Jasper", SeatLat = 30.92135, SeatLon = -93.99704, Area = 970 },
                    new County { CntyFIPS = "245", CntyName = "Jefferson", Territory = "NCST", Seat = "Beaumont", SeatLat = 30.08704, SeatLon = -94.10206, Area = 1113 },
                    new County { CntyFIPS = "247", CntyName = "Jim Hogg", Territory = "CSBND", Seat = "Hebbronville", SeatLat = 27.30736, SeatLon = -98.67841, Area = 1136 },
                    new County { CntyFIPS = "249", CntyName = "Jim Wells", Territory = "CSBND", Seat = "Alice", SeatLat = 27.75059, SeatLon = -98.06575, Area = 868 },
                    new County { CntyFIPS = "261", CntyName = "Kenedy", Territory = "CSBND", Seat = "Sarita", SeatLat = 27.22333, SeatLon = -97.78936, Area = 1946 },
                    new County { CntyFIPS = "273", CntyName = "Kleberg", Territory = "CSBND", Seat = "Kingsville", SeatLat = 27.51587, SeatLon = -97.85522, Area = 1090 },
                    new County { CntyFIPS = "285", CntyName = "Lavaca", Territory = "CXRD", Seat = "Hallettsville", SeatLat = 29.45085, SeatLon = -96.94131, Area = 970 },
                    new County { CntyFIPS = "291", CntyName = "Liberty", Territory = "CNCST", Seat = "Liberty", SeatLat = 30.0584, SeatLon = -94.79709, Area = 1176 },
                    new County { CntyFIPS = "297", CntyName = "Live Oak", Territory = "CXRD", Seat = "George West", SeatLat = 28.33138, SeatLon = -98.11609, Area = 1079 },
                    new County { CntyFIPS = "321", CntyName = "Matagorda", Territory = "INLD", Seat = "Bay City", SeatLat = 28.98403, SeatLon = -95.96985, Area = 1612 },
                    new County { CntyFIPS = "311", CntyName = "McMullen", Territory = "CXRD", Seat = "Tilden", SeatLat = 28.4617, SeatLon = -98.54931, Area = 1157 },
                    new County { CntyFIPS = "339", CntyName = "Montgomery", Territory = "SAMH", Seat = "Conroe", SeatLat = 30.31211, SeatLon = -95.45549, Area = 1077 },
                    new County { CntyFIPS = "347", CntyName = "Nacogdoches", Territory = "DPEST", Seat = "Nacogdoches", SeatLat = 31.60379, SeatLon = -94.65562, Area = 981 },
                    new County { CntyFIPS = "351", CntyName = "Newton", Territory = "NCST", Seat = "Newton", SeatLat = 30.84849, SeatLon = -93.76023, Area = 940 },
                    new County { CntyFIPS = "355", CntyName = "Nueces", Territory = "CSBND", Seat = "Corpus Christi", SeatLat = 27.79636, SeatLon = -97.40401, Area = 1166 },
                    new County { CntyFIPS = "361", CntyName = "Orange", Territory = "NCST", Seat = "Orange", SeatLat = 30.09493, SeatLon = -93.73877, Area = 380 },
                    new County { CntyFIPS = "373", CntyName = "Polk", Territory = "SAMH", Seat = "Livingston", SeatLat = 30.71381, SeatLon = -94.9347, Area = 1110 },
                    new County { CntyFIPS = "391", CntyName = "Refugio", Territory = "CXRD", Seat = "Refugio", SeatLat = 28.30594, SeatLon = -97.27519, Area = 818 },
                    new County { CntyFIPS = "403", CntyName = "Sabine", Territory = "DPEST", Seat = "Hemphill", SeatLat = 31.34197, SeatLon = -93.84791, Area = 577 },
                    new County { CntyFIPS = "405", CntyName = "San Augustine", Territory = "DPEST", Seat = "San Augustine", SeatLat = 31.52901, SeatLon = -94.10662, Area = 592 },
                    new County { CntyFIPS = "407", CntyName = "San Jacinto", Territory = "SAMH", Seat = "Coldspring", SeatLat = 30.59272, SeatLon = -95.12897, Area = 628 },
                    new County { CntyFIPS = "409", CntyName = "San Patricio", Territory = "CSBND", Seat = "Sinton", SeatLat = 28.03755, SeatLon = -97.5094, Area = 708 },
                    new County { CntyFIPS = "419", CntyName = "Shelby", Territory = "DPEST", Seat = "Center", SeatLat = 31.79617, SeatLon = -94.17977, Area = 835 },
                    new County { CntyFIPS = "427", CntyName = "Starr", Territory = "STEX", Seat = "Rio Grande City", SeatLat = 26.37828, SeatLon = -98.81596, Area = 1229 },
                    new County { CntyFIPS = "455", CntyName = "Trinity", Territory = "DPEST", Seat = "Groveton", SeatLat = 31.05563, SeatLon = -95.1273, Area = 714 },
                    new County { CntyFIPS = "457", CntyName = "Tyler", Territory = "NCST", Seat = "Woodville", SeatLat = 32.3478, SeatLon = -95.29431, Area = 936 },
                    new County { CntyFIPS = "469", CntyName = "Victoria", Territory = "CXRD", Seat = "Victoria", SeatLat = 28.80596, SeatLon = -97.00337, Area = 889 },
                    new County { CntyFIPS = "471", CntyName = "Walker", Territory = "SAMH", Seat = "Huntsville", SeatLat = 30.7241, SeatLon = -95.55215, Area = 802 },
                    new County { CntyFIPS = "473", CntyName = "Waller", Territory = "INLD", Seat = "Hempstead", SeatLat = 30.09804, SeatLon = -96.08113, Area = 518 }

                    );
                context.SaveChanges();
            }

        } // eo EnsurePopulated static method -----------------------------------------------------
    } // eo CountySeedData class ------------------------------------------------------------------
} // eo namespace
