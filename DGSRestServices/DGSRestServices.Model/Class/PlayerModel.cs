using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Model.Class
{
    public class PlayerModel
    {


        #region Atributes
        bool isValid { set; get; } = false;
        StringBuilder sbMessage = new StringBuilder ();
        #endregion

        #region Properties  

        public int IdPlayer { get; set; }
        public short IdLineType { get; set; }
        public byte IdOffice { get; set; }
        public int IdAgent { get; set; }
        public short IdCurrency { get; set; }
        public short IdGrouping { get; set; }
        public short IdSource { get; set; }
        public short IdProfile { get; set; }
        public short IdPlayerRate { get; set; }
        public short IdBook { get; set; }
        public byte IdTimeZone { get; set; }
        public byte IdLanguage { get; set; } = 1;
        public string ScheduleStyle { get; set; } = "A";
        public string Player { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string LastName2 { get; set; }
        public string Title { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public bool AutoPay { get; set; }
        public bool BalanceChecked { get; set; }
        public decimal CreditLimit { get; set; }
        public bool NoLimit { get; set; }
        public decimal TempCredit { get; set; }
        public byte SoftLimitPercent { get; set; }
        public DateTime TempCreditExpire { get; set; }
        public bool OnlineAccess { get; set; }
        public string OnlinePassword { get; set; }
        public string OnlineMessage { get; set; }
        public decimal OnlineMaxWager { get; set; }
        public decimal OnlineMinWager { get; set; }
        public decimal MaxWager { get; set; }
        public decimal MinWager { get; set; }
        public decimal CapPerGame { get; set; }
        public short ChartPercent { get; set; }
        public short MasterChart { get; set; }
        public bool Master { get; set; }
        public string FlagMessage { get; set; }
        public byte IdFlagMessageType { get; set; }
        public byte MaxActionPoints { get; set; }
        public string BonusPointsStatus { get; set; }  //Validar que no sea NULL
        public DateTime BonusPointsExpire { get; set; }
        public DateTime BonusPointsStart { get; set; }
        public string LineStyle { get; set; } //Validar que no sea NULL
        public string NHLLine { get; set; } //Validar que no sea NULL
        public string MLBLine { get; set; } //Validar que no sea NULL 
        public byte PitcherDefault { get; set; }
        public bool DuplicatedBets { get; set; }
        public bool DuplicatedBetsOnline { get; set; }
        public decimal FreePlayAmount { get; set; }
        public string FreePlayMessage { get; set; }
        public bool ScheduleFB { get; set; }
        public bool ScheduleBB { get; set; }
        public bool ScheduleHK { get; set; }
        public bool ScheduleBS { get; set; }
        public decimal SettledFigure { get; set; }
        public bool ShowInTicker { get; set; }
        public bool EPOSPlayer { get; set; }
        public bool EnableHorses { get; set; }
        public bool EnableCasino { get; set; }
        public bool EnableSports { get; set; } = true;
        public DateTime DateOfBirth { get; set; } = new DateTime(1970 - 1 - 1);
        public string SecQuestion { get; set; }
        public string SecAnswer { get; set; }
        public string SignUpIP { get; set; } = "0.0.0.0";
        public bool AllowNegTrans { get; set; } = false;
        public short LastModificationUser { get; set; }
        public bool HoldBets { get; set; } = false;
        public byte HoldDelay { get; set; } = 0;
        public short IdProfileLimits { get; set; } = 1;
        public bool EnableCards      { get ; set ;} = true;
                                              




        #endregion


        #region Methods 

        /// <summary>
        /// allow validate a players
        /// </summary>
        /// <returns></returns>
        public bool isvalidPlayer()
        {
            StringBuilder sbValidate = new StringBuilder();

            if (! isValidString(this.Player))                 
            {
                sbValidate.AppendFormat("The value for the field [Player] can not be null");               
            }
            if (!isValidString(this.Password))
            {
                sbValidate.AppendFormat("The value for the field [Password] can not be null");               
            }       
            if (!isValidString(this.LineStyle.ToString()))
            {
                sbValidate.AppendFormat("The value for the field [LineStyle] can not be null");               
            }
            if (!isValidString(this.NHLLine.ToString()))
            {
                sbValidate.AppendFormat("The value for the field [NHLLine] can not be null");               
            }

            if (!isValidString(this.MLBLine.ToString()))
            {
                sbValidate.AppendFormat("The value for the field [MLBLine] can not be null");               
            }

            if(sbValidate.Length>0)
               return false;

            return true;
        }

        
        public bool isValidString ( string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(value) || string.IsNullOrEmpty(value))
                return false;
            return true;
        }
    


        #endregion
    }
}
