﻿using System;

namespace BookClasses
{
    public class clsReview
    {
        private int mReviewNo;
        private string mReviewerName;
        private DateTime mDateAdded;
        private int mStar;
        private bool mWouldUse;
        private bool mActive;

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }

        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public int ReviewNo 
        {
            get
            {
                
                return mReviewNo;
            }
            set
            {
                
                mReviewNo = value;
            }
        }
        public string ReviewerName 
        { 
            get
            {
                return mReviewerName;
            }
            set
            {
                mReviewerName = value;
            }
        }
        public int Star 
        { 
            get
            {
                return mStar;
            }
            set
            {
                mStar = value;
            }
                }
        public bool WouldUse 
        { 
            get
            {
                return mWouldUse;
            }
            set
            {
                mWouldUse = value;
            }
        }


        public bool Find(int ReviewNo)
        {
            
            mReviewNo = 3;
            mReviewerName = "Paul";
            mActive = true;
            mDateAdded = Convert.ToDateTime("06/06/2018");
            mStar = 5;
            mWouldUse = true;
            //always return true
            return true;
        }
    }
}