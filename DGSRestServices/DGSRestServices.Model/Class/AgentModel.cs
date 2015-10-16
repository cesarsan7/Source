using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Model.Class
{
    public class AgentModel
    {
        private short mIdAgent = 0;
        private short mIdCurrency = 0;
        private short mIdBook = 0;
        private string mAgent ;
        private short mIdAgentType = 0;
        private short mIdGrouping = 0;
        private int mDistributor = 0;
        private string mPassword ;
        private bool mEnable = false;
        private string mName ;
        private string mAddress1 ;
        private string mAddress2 ;
        private string mCity ;
        private string mState ;
        private string mCountry ;
        private string mZip ;
        private string mPhone ;
        private string mFax ;
        private string mEmail ;
        private bool mIsDistributor = false;
        private bool mDontXferPlayerActivity = false;
        private bool mIsDistributed = false;
        private byte mCommSports = 0;
        private byte mCommCasino = 0;
        private byte mCommHorses = 0;
        private decimal mPerHeadSports = 0;
        private decimal mPerHeadCasino = 0;
        private decimal mPerHeadHorses = 0;
        private bool mOnlineAccess = false;
        private string mOnlineMessage ;
        private DateTime mLastModification = DateTime.Now;
        private int mLastModificationUser = 0;
        private short mIdLineType = 0;
        private int mIdUser = 0;
        private decimal mprMakeup = 0;


        public short IdAgent
        {
            get
            {
                return mIdAgent;
            }
            set
            {
                mIdAgent = value;
            }
        }

        public int IdUser
        {
            get
            {
                return mIdUser;
            }
            set
            {
                mIdUser = value;
            }
        }

        public short IdCurrency
        {
            get
            {
                return mIdCurrency;
            }
            set
            {
                mIdCurrency = value;
            }
        }

        public short IdBook
        {
            get
            {
                return mIdBook;
            }
            set
            {
                mIdBook = value;
            }
        }

        public String Agent
        {
            get
            {
                return mAgent;
            }
            set
            {
                mAgent = value;
            }
        }

        public short IdAgentType
        {
            get
            {
                return mIdAgentType;
            }
            set
            {
                mIdAgentType = value;
            }
        }

        public short IdGrouping
        {
            get
            {
                return mIdGrouping;
            }
            set
            {
                mIdGrouping = value;
            }
        }

        public int Distributor
        {
            get
            {
                return mDistributor;
            }
            set
            {
                mDistributor = value;
            }
        }

        public String Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        public Boolean Enable
        {
            get
            {
                return mEnable;
            }
            set
            {
                mEnable = value;
            }
        }

        public String Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public String Address1
        {
            get
            {
                return mAddress1;
            }
            set
            {
                mAddress1 = value;
            }
        }

        public String Address2
        {
            get
            {
                return mAddress2;
            }
            set
            {
                mAddress2 = value;
            }
        }

        public String City
        {
            get
            {
                return mCity;
            }
            set
            {
                mCity = value;
            }
        }

        public String State
        {
            get
            {
                return mState;
            }
            set
            {
                mState = value;
            }
        }

        public String Country
        {
            get
            {
                return mCountry;
            }
            set
            {
                mCountry = value;
            }
        }

        public String Zip
        {
            get
            {
                return mZip;
            }
            set
            {
                mZip = value;
            }
        }

        public String Phone
        {
            get
            {
                return mPhone;
            }
            set
            {
                mPhone = value;
            }
        }

        public String Fax
        {
            get
            {
                return mFax;
            }
            set
            {
                mFax = value;
            }
        }

        public String Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public Boolean IsDistributor
        {
            get
            {
                return mIsDistributor;
            }
            set
            {
                mIsDistributor = value;
            }
        }

        public Boolean DontXferPlayerActivity
        {
            get
            {
                return mDontXferPlayerActivity;
            }
            set
            {
                mDontXferPlayerActivity = value;
            }
        }

        public Boolean IsDistributed
        {
            get
            {
                return mIsDistributed;
            }
            set
            {
                mIsDistributed = value;
            }
        }

        public byte CommSports
        {
            get
            {
                return mCommSports;
            }
            set
            {
                mCommSports = value;
            }
        }

        public byte CommCasino
        {
            get
            {
                return mCommCasino;
            }
            set
            {
                mCommCasino = value;
            }
        }

        public byte CommHorses
        {
            get
            {
                return mCommHorses;
            }
            set
            {
                mCommHorses = value;
            }
        }

        public decimal PerHeadSports
        {
            get
            {
                return mPerHeadSports;
            }
            set
            {
                mPerHeadSports = value;
            }
        }

        public decimal Makeup
        {
            get
            {
                return mprMakeup;
            }
            set
            {
                mprMakeup = value;
            }
        }

        public decimal PerHeadCasino
        {
            get
            {
                return mPerHeadCasino;
            }
            set
            {
                mPerHeadCasino = value;
            }
        }

        public decimal PerHeadHorses
        {
            get
            {
                return mPerHeadHorses;
            }
            set
            {
                mPerHeadHorses = value;
            }
        }

        public Boolean OnlineAccess
        {
            get
            {
                return mOnlineAccess;
            }
            set
            {
                mOnlineAccess = value;
            }
        }

        public String OnlineMessage
        {
            get
            {
                return mOnlineMessage;
            }
            set
            {
                mOnlineMessage = value;
            }
        }

        public DateTime LastModification
        {
            get
            {
                return mLastModification;
            }
            set
            {
                mLastModification = value;
            }
        }

        public int LastModificationUser
        {
            get
            {
                return mLastModificationUser;
            }
            set
            {
                mLastModificationUser = value;
            }
        }

        public short IdLineType
        {
            get
            {
                return mIdLineType;
            }
            set
            {
                mIdLineType = value;
            }
        }

        public static object Date { get; private set; }
    }
}
