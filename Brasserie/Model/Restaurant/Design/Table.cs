using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Brasserie.Model.Restaurant.Design
{
    public class Table
    {
        const byte MIN_SEATS = 2;
        const byte MIN_TABLE_NUMBER = 1;

        private int _idNumber;
        private int _seatsNumber;
        private bool _isNowBusy;

        private static int _totalSeats;

        public Table (int id, int seatsNumber, bool isNowBusy)
        {
            _idNumber = id;
            _seatsNumber = seatsNumber;
            _isNowBusy = isNowBusy;

            _totalSeats += seatsNumber;
        }


        #region Accesseur
        public int Id 
        { 
            get => _idNumber;

            set
            {
                if (CheckIdNumber(value))
                {
                    _idNumber = value;
                }
            }
        }

        public int SeatNumber 
        { 
            get => _seatsNumber; 

            set
            {
                if (CheckSeatsNumber(value))
                {
                    _seatsNumber = value;
                }
            }
        }
        public static int TotalSeats { get => _totalSeats;set => _totalSeats = value;}
        public bool IsNowBusy { get => _isNowBusy; set => _isNowBusy = value; }
        #endregion


        #region Méthodes
        private bool CheckSeatsNumber(int seatsNumber) 
        {
            return seatsNumber >= MIN_SEATS;
        }

        private bool CheckIdNumber(int idNumber)
        {
            return idNumber >= MIN_TABLE_NUMBER;
        }
        #endregion
    }
}
