using DGSRestServices.Data;
using DGSRestServices.Model.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Controller.Class
{
   public class PlayerController
    {

        #region Atributes
        DGSDATAEntities entities = null;
        #endregion Atributes

        #region Properties
        #endregion Properties

        #region Method Constructor 

        /// <summary>
        /// Method constructor the class BookController
        /// </summary>
        public PlayerController()
        {
            entities = new DGSDATAEntities();
        }

		#endregion

		#region Methods CRUD 

		#region GET Methods 

		public IEnumerable<dynamic>  playerGetInfoController(string player,short idUser)
        {


            Repository<Agent_FindList_Result> objResult = new Repository<Agent_FindList_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Player_GetInfo(player, idUser);

                if (lstEntity != null)
                {
                    var result = (from data in lstEntity
                                  select  new 
                                  {
									  IdPlayer			= data.IdPlayer,
									  IdLineType		= data.IdLineType,
									  IdOffice			= data.IdOffice,
									  IdAgent = data.IdAgent,
									  IdCurrency = data.IdCurrency,
									  IdGrouping = data.IdGrouping,
									  IdSource = data.IdSource,
									  IdProfile = data.IdProfile,
									  IdProfileLimits = data.IdProfileLimits,
									  IdPlayerRate = data.IdPlayerRate,
									  IdBook = data.IdBook,
									  IdTimeZone = data.IdTimeZone,
									  IdLanguage = data.IdLanguage,
									  ScheduleStyle = data.ScheduleStyle,
									  Player = data.Player,
									  Password = data.Password,
									  Name = data.Name,
									  LastName = data.LastName,
									  LastName2 = data.LastName2,
									  Title = data.Title,
									  Address1 = data.Address1,
									  Address2 = data.Address2,
									  City = data.City,
									  State = data.State,
									  Country = data.Country,
									  Zip = data.Zip,
									  Phone = data.Phone,
									  Fax = data.Fax,
									  Email = data.Email,
									  Status = data.Status,
									  AutoPay = data.AutoPay,
									  BalanceChecked = data.BalanceChecked,
									  CreditLimit = data.CreditLimit,
									  NoLimit = data.NoLimit,
									  TempCredit = data.TempCredit,
									  SoftLimitPercent = data.SoftLimitPercent,
									  TempCreditExpire = data.TempCreditExpire,
									  OnlineAccess = data.OnlineAccess,
									  OnlinePassword = data.OnlinePassword,
									  OnlineMessage = data.OnlineMessage,
									  OnlineMaxWager = data.OnlineMaxWager,
									  OnlineMinWager = data.OnlineMinWager,
									  MaxWager = data.MaxWager,
									  MinWager = data.MinWager,
									  CapPerGame = data.CapPerGame,
									  ChartPercent = data.ChartPercent,
									  MasterChart = data.MasterChart,
									  Master = data.Master,
									  FlagMessage = data.FlagMessage,
									  IdFlagMessageType = data.IdFlagMessageType,
									  MaxActionPoints = data.MaxActionPoints,
									  BonusPointsStatus = data.BonusPointsStatus,
									  BonusPointsExpire = data.BonusPointsExpire,
									  BonusPointsStart = data.BonusPointsStart,
									  LineStyle = data.LineStyle,
									  NHLLine = data.NHLLine,
									  MLBLine = data.MLBLine,
									  PitcherDefault = data.PitcherDefault,
									  DuplicatedBets = data.DuplicatedBets,
									  DuplicatedBetsOnline = data.DuplicatedBetsOnline,
									  FreePlayAmount = data.FreePlayAmount,
									  FreePlayMessage = data.FreePlayMessage,
									  ScheduleFB = data.ScheduleFB,
									  ScheduleBB = data.ScheduleBB,
									  ScheduleHK = data.ScheduleHK,
									  ScheduleBS = data.ScheduleBS,
									  SettledFigure = data.SettledFigure,
									  ShowInTicker = data.ShowInTicker,
									  EPOSPlayer = data.EPOSPlayer,
									  EnableHorses = data.EnableHorses,
									  EnableCasino = data.EnableCasino,
									  EnableSports = data.EnableSports,
									  EnableCards = data.EnableCards,
									  DateOfBirth = data.DateOfBirth,
									  SignUpIP = data.SignUpIP,
									  SecQuestion = data.SecQuestion,
									  SecAnswer = data.SecAnswer,
									  HoldBets = data.HoldBets,
									  HoldDelay = data.HoldDelay,
									  LastModificationUser = data.LastModificationUser ,
									  Currency           = data.Currency,
									  Symbol             =data.Symbol,
									  AgentEnabled =data.AgentEnabled,
									  DontXFerPlayerActivity =data.DontXFerPlayerActivity

								  }).ToList();

                    return result;
                }
                return null;
            }
            catch
            {
                throw;
            }
           
        }
        #endregion  GET Methods 

        #region POST Methods 

        public int addPlayerController(PlayerModel model , short IdUser, ref ObjectParameter prmOutIdPlayer, ref ObjectParameter prmOutResult)
        {
            int res = 0;
            res = entities.Player_Insert(   model.IdLineType,
                                            model.IdOffice,
                                            model.IdAgent,
                                            model.IdCurrency,
                                            model.IdGrouping,
                                            model.IdSource,
                                            model.IdProfile,
                                            model.IdProfileLimits,
                                            model.IdPlayerRate,
                                            model.IdBook,
                                            model.IdTimeZone,
                                            model.IdLanguage,
                                            model.ScheduleStyle,
                                            model.Player,
                                            model.Password,
                                            model.Name,
                                            model.LastName,
                                            model.LastName2,
                                            model.Title,
                                            model.Address1,
                                            model.Address2,
                                            model.City,
                                            model.State,
                                            model.Country,
                                            model.Zip,
                                            model.Phone,
                                            model.Fax,
                                            model.Email,
                                            model.Status,
                                            model.AutoPay,
                                            model.BalanceChecked,
                                            model.CreditLimit,
                                            model.NoLimit,
                                            model.TempCredit,
                                            model.SoftLimitPercent,
                                            model.TempCreditExpire,
                                            model.OnlineAccess,
                                            model.OnlinePassword,
                                            model.OnlineMessage,
                                            model.OnlineMaxWager,
                                            model.OnlineMinWager,
                                            model.MaxWager,
                                            model.MinWager,
                                            model.ChartPercent,
                                            model.MasterChart,
                                            model.Master,
                                            model.IdFlagMessageType,
                                            model.MaxActionPoints,
                                            model.BonusPointsStatus,
                                            model.BonusPointsExpire,
                                            model.BonusPointsStart,
                                            model.LineStyle,
                                            model.NHLLine,
                                            model.MLBLine,
                                            model.PitcherDefault,
                                            model.DuplicatedBets,
                                            model.DuplicatedBetsOnline,
                                            model.ScheduleFB,
                                            model.ScheduleBB,
                                            model.ScheduleHK,
                                            model.ScheduleBS,
                                            model.SettledFigure,
                                            model.ShowInTicker,
                                            model.EPOSPlayer,
                                            model.EnableSports,
                                            model.EnableCasino,
                                            model.EnableHorses,
                                            model.EnableCards,
                                            model.DateOfBirth,
                                            model.SignUpIP,
                                            model.SecQuestion,
                                            model.SecAnswer,
                                            model.HoldBets,
                                            model.HoldDelay,
                                            IdUser,
                                            prmOutIdPlayer,
                                            prmOutResult
                                       );
            return res;
        }
        #endregion  POST Methods 

        #region PUT Methods 
        #endregion  PUT Methods


        #region DELETE Methods 
        #endregion  DELETE Methods

        #endregion Methods CRUD
    }
}
