using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemoConsole
{
    //A simple printer tasks
    public interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }
    //An advance printer Tasks
    public interface IFaxContent
    {
        bool FaxContent(string content);
    }
    public interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
}
