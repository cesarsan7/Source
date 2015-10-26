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
