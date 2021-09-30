using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// a class “Car”, which has the following properties:
    /// public string Licenseplate
    /// public DateTime Date
    /// </summary>

    public class Car : VehicleBase
    {
        #region Constructors

        //Refactoring: properties have been moved to VehicleBase class
        //public string Licenseplate { get; set; }
        //public DateTime Date { get; set; }

        /// <summary>
        /// public constructor Car with no argument
        /// </summary>
        public Car()
        {
        }

        /// <summary>
        /// public constructor Car with argument bool brobizz
        /// </summary>
        public Car(bool brobizz) : base(brobizz)
        {
            HasBrobizz = brobizz;
        }


        /// <summary>
        /// constructor with argument 
        /// </summary>
        public Car(string plate)
        {
            Licenseplate = plate;
        }

        /// <summary>
        /// public constructor Car with 3 arguments
        /// </summary>
        /// <param name="plate"></param>
        /// <param name="date"></param>
        /// <param name="brobizz"></param>
        public Car(string plate, DateTime date, bool brobizz = false) : base(plate, date, brobizz)
        {
            Licenseplate = plate;
            Date = date;
            HasBrobizz = brobizz;
        }

        #endregion


        #region Metbods
        /// <summary>
        /// method 
        /// public double Price() 
        /// </summary>
        /// <returns>double Price() = 240 as fixed price</returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// method
        /// public string VehicleType() 
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }

        #endregion

    }
}
