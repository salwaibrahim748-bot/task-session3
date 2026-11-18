using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    public class Class1
    {
        #region  11 interfaces
        public interface IFlyable
        {
            string Move();
        }
        public interface ISwimmable
        {
            string Move();
        }
        public interface IWalkable
        {
            string Move();
        }
        #endregion
        #region 12 class Duck
        public class Duck : IFlyable, ISwimmable, IWalkable
        {
            string IFlyable.Move()
            {
                return "Duck is flying in the sky ";
            }
            string ISwimmable.Move()
            {
                return "Duck is swimming in the water ";
            }
            #region 14
            string IWalkable.Move()
            {
                return "Duck is walking on the ground!";
            } 
            #endregion
        } 
        #endregion
    }
}
