using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;
            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;
            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;


        }
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents individual team's placement after the tournament.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the title for the finishing place of the individual team.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents prize amount given the team's final placement.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents prize percentage given the team's final placement.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
