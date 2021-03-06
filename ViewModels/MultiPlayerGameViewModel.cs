﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MazeLib;

namespace ViewModels
{
    public class MultiPlayerGameViewModel : ViewModel
    {
        private IMultiGameModel gm;
        private double xAdvancment;
        private double yAdvancment;

        public MultiPlayerGameViewModel(IMultiGameModel gm)
        {
            this.gm = gm;
        }

        public string IP
        {
            get
            {
                return this.gm.IP;
            }
        }

        public int Port
        {
            get
            {
                return this.gm.Port;
            }
        }

        public int SearchAlgorithm
        {
            get
            {
                return this.gm.SearchAlgorithm;
            }
        }
        public double XAdvancment
        {
            set
            {
                xAdvancment = value;
            }
        }
        public double YAdvancment
        {
            set
            {
                yAdvancment = value;
            }
        }

        public double XLocation
        {
            get
            {
                return this.gm.XLocation;
            }
        }

        public double YLocation
        {
            get
            {
                return this.gm.YLocation;
            }
        }


        public double OpponentXLocation
        {
            get
            {
                return this.gm.OpponentXLocation;
            }
        }

        public double OpponentYLocation
        {
            get
            {
                return this.gm.OpponentYLocation;
            }
        }

        public double PicX
        {
            get
            {
                return this.XLocation * this.xAdvancment;
            }
        }

        public double PicY
        {
            get
            {
                return this.YLocation * this.yAdvancment;
            }
        }

        public double OpponentPicX
        {
            get
            {
                return this.OpponentXLocation * this.xAdvancment;
            }
        }

        public double OpponentPicY
        {
            get
            {
                return this.OpponentYLocation * this.yAdvancment;
            }
        }

        public Position InitialPos
        {
            get
            {
                return gm.InitialPos;
            }

        }
        public Position GoalPos
        {
            get
            {
                return gm.GoalPos;
            }
        }
        public string PlayerImageFile
        {
            get
            {
                return gm.PlayerImageFile;
            }
            set
            {
                gm.PlayerImageFile = value;
            }
        }
        public string ExitImageFile
        {
            get
            {
                return gm.ExitImageFile;
            }
            set
            {
                gm.ExitImageFile = value;
            }
        }

        public Maze MazeObject
        {
            set
            {
                gm.MazeObject = value;
            }
        }

        public string Maze
        {
            get
            {
                return gm.Maze.ToString();
            }
        }
        public string MazeName
        {
            get
            {
                return gm.MazeName;
            }
        }

        public int Rows
        {
            get
            {
                return this.gm.Rows;
            }

        }

        public int Cols
        {
            get
            {
                return this.gm.Cols;
            }
        }

        public string MoveInGame(Direction d)
        {
            string result = gm.MoveInGame(d);
            NotifyPropertyChanged("PicX");
            NotifyPropertyChanged("PicY");
            return result;

        }

        public string OtherPlayerMove(Direction d)
        {
            string result = gm.OtherPlayerMove(d);
            NotifyPropertyChanged("OpponentPicX");
            NotifyPropertyChanged("OpponentPicY");
            return result;
        }

    }
}
