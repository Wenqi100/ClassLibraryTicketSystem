using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// a class “MC”, which has the following properties:
    /// public string Licenseplate
    /// public DateTime Date
    /// </summary>
    public class MC : VehicleBase
    {
        #region Constructors

        //Refactoring: properties have been moved to VehicleBase class
        //public string Licenseplate { get; set; }
        //public DateTime Date { get; set; }

        /// <summary>
        /// public constructor MC with no argument
        /// </summary>
        public MC()
        {
        }

        /// <summary>
        /// public constructor Car with argument bool brobizz
        /// </summary>
        public MC(bool brobizz) : base(brobizz)
        {
            HasBrobizz = brobizz;
        }

        /// <summary>
        /// constructor with argument 
        /// </summary>
        public MC(string plate)
        {
            Licenseplate = plate;
        }

        /// <summary>
        /// public constructor MC with 3 arguments 
        /// </summary>
        public MC(string plate, DateTime date, bool brobizz = false) : base(plate, date, brobizz)
        {
            Licenseplate = plate;
            Date = date;
            HasBrobizz = brobizz;
        }

        #endregion


        #region Methods
        /// <summary>
        /// method 
        /// public double Price() 
        /// </summary>
        /// <returns>double Price() = 125 as fixed price</returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// method
        /// public string VehicleType() 
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }

        #endregion       
    }
}
