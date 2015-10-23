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

        int IdPlayer { set; get; }
        short IdLineType { set; get; }
        short IdOffice { set; get; }
        int IdAgent { set; get; }
        short IdCurrency { set; get; }
        short IdGrouping { set; get; }
        short IdSource { set; get; }
        short IdProfile { set; get; }
        short IdPlayerRate { set; get; }
        short IdBook { set; get; }
        int IdTimeZone { set; get; } = 1;
        short IdLanguage { set; get; } = 1;
        char ScheduleStyle { set; get; } = 'A';
	    string Player { set; get; }
        string Password { set; get; }
        string Name { set; get; }
        string LastName { set; get; }
        string LastName2 { set; get; }
        string Title { set; get; }
        string Address1 { set; get; }
        string Address2 { set; get; }
        string City { set; get; }
        string State { set; get; }
        string Country { set; get; }
        string Zip { set; get; }
        string Phone { set; get; }
        string Fax { set; get; }
        string Email { set; get; }
        char Status { set; get; }
        bool AutoPay { set; get; }
        bool BalanceChecked { set; get; }
        decimal CreditLimit { set; get; }
        bool NoLimit { set; get; }
        decimal TempCredit { set; get; }
        short SoftLimitPercent { set; get; }
        DateTime TempCreditExpire { set; get; }
        bool OnlineAccess { set; get; }
        string OnlinePassword { set; get; }
        string OnlineMessage { set; get; }
        decimal OnlineMaxWager { set; get; }
        decimal OnlineMinWager { set; get; }
        decimal MaxWager { set; get; }
        decimal MinWager { set; get; }
        decimal CapPerGame { set; get; }
        short ChartPercent { set; get; }
        short MasterChart { set; get; }
        bool Master { set; get; }
        string FlagMessage { set; get; }
        short IdFlagMessageType { set; get; }
        short MaxActionPoints { set; get; }
        char BonusPointsStatus { set; get; }
        DateTime BonusPointsExpire { set; get; }
        DateTime BonusPointsStart { set; get; }
        char LineStyle { set; get; }
        char NHLLine { set; get; }
        char MLBLine { set; get; }
        char PitcherDefault { set; get; }
        bool DuplicatedBets { set; get; }
        bool DuplicatedBetsOnline { set; get; }
        decimal FreePlayAmount { set; get; }
        string FreePlayMessage { set; get; }
        bool ScheduleFB { set; get; }
        bool ScheduleBB { set; get; }
        bool ScheduleHK { set; get; }
        bool ScheduleBS { set; get; }
        decimal SettledFigure { set; get; }
        bool ShowInTicker { set; get; }
        bool EPOSPlayer { set; get; }
        bool EnableHorses { set; get; }
        bool EnableCasino { set; get; }
        bool EnableSports { set; get; } = true;
        DateTime DateOfBirth { set; get; } = new DateTime(1970, 1, 1);
        string SecQuestion { set; get; }
        string SecAnswer { set; get; }
        string SignUpIP  { set ; get; } ="0.0.0.0";
	    bool AllowNegTrans { set; get; } = false;
        short LastModificationUser                 { set ; get; }
	    bool HoldBets { set; get; } = false;
        short HoldDelay { set; get; } = 0;
        short IdProfileLimits { set; get; } = 1;
        short EnableCards  { set; get; } = 1;

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
