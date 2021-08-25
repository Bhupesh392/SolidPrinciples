using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    public interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);

        //Should not be part of the IUser interface.
        //void LogError(string error);
        //bool SendEmail(string emailContent);
    }

    //So what you do is that you divide these responsiblities to different interfaces. doesn't matter if it has only one method.

    public interface ILogger
    {
        void LogError(string error);
    }
    public interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
