using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Model.Class
{
    public class AgentModel
    {
        private int mIdAgent = 0;
        private int mIdCurrency = 0;
        private int mIdBook = 0;
        private string mAgent ;
        private int mIdAgentType = 0;
        private int mIdGrouping = 0;
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
        private int mCommSports = 0;
        private int mCommCasino = 0;
        private int mCommHorses = 0;
        private double mPerHeadSports = 0.0;
        private double mPerHeadCasino = 0.0;
        private double mPerHeadHorses = 0.0;
        private bool mOnlineAccess = false;
        private string mOnlineMessage ;
        private DateTime mLastModification = DateTime.Now;
        private int mLastModificationUser = 0;
        private int mIdLineType = 0;

        public int IdAgent
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

        public int IdCurrency
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

        public int IdBook
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

        public int IdAgentType
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

        public int IdGrouping
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

        public int CommSports
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

        public int CommCasino
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

        public int CommHorses
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

        public Double PerHeadSports
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

        public Double PerHeadCasino
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

        public Double PerHeadHorses
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

        public int IdLineType
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
