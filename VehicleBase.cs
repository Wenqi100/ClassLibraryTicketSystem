using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// a class “VehicleBase”, which has the following properties:
    /// public string Licenseplate
    /// public DateTime Date
    /// </summary>
    public abstract class VehicleBase
    {
        #region Properties

        /// <summary>
        /// _licensePlate;
        /// </summary>
        private string _licensePlate;

        /// <summary>
        /// set "The length of Licenseplate can not longer than 7."
        /// </summary>
        public string Licenseplate
        {
            get => _licensePlate;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("The length of Licenseplate can not be longer than 7.");
                }
                _licensePlate = value;
            }
        }


        /// <summary>
        /// DateTime Date
        /// </summary>
        public DateTime Date { get; set; }


        /// <summary>
        /// public bool field, HasBrobizz;
        /// default value is false
        /// </summary>
        public bool HasBrobizz { get; set; }  // default value = false

        #endregion


        #region Constructors
        /// <summary>
        /// constructor with no arguments
        /// </summary>
        public VehicleBase()
        {
        }

        /// <summary>
        /// constructor with argument bool brobizz
        /// </summary>
        public VehicleBase(bool brobizz)
        {
            HasBrobizz = brobizz;
        }

        /// <summary>
        /// constructor with argument 
        /// </summary>
        public VehicleBase(string plate)
        {
            Licenseplate = plate;
        }


        /// <summary>
        /// constructor with 3 arguments
        /// </summary>
        public VehicleBase(string plate, DateTime date, bool brobizz)
        {
            Licenseplate = plate;
            Date = date;
            HasBrobizz = brobizz;
        }

        #endregion


        #region Methods
        /// <summary>
        /// method 
        /// public abstract double Price() 
        /// </summary>
        /// <returns>double Price</returns>
        public abstract double Price();

        /// <summary>
        /// method
        /// public abstract string VehicleType() 
        /// </summary>
        /// <returns>string VehicleType</returns>
        public abstract string VehicleType();


        /// <summary>
        /// method
        /// public bool IsLengthCorrect(string licenseplate) 
        /// </summary>
        /// <returns>string VehicleType</returns>

        public bool IsLengthCorrect(string licenseplate)
        {
            return licenseplate.Length <= 7 ? true : false;
        }
        


        /// <summary>
        /// method
        /// public double GetPriceByBrobizz(double discount) 
        /// </summary>
        /// <returns>double priceWithBrobizz</returns>
        public double GetPriceByBrobizz(double discount)
        {
            if (HasBrobizz == true)
            {
                discount = 5.0 / 100;
                double priceWithBrobizz = Price() * (1.0 - discount);
                return priceWithBrobizz;
            }

            return Price();
        }

        #endregion


    }
}
