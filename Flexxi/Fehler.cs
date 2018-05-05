using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flexxi
{
    public class Fehler
    {
        // bei const braucht man kein static, weil das dann automatisch schon ist
        public const byte ErrorCantReadFile = 0;
        public const byte ErrorCantWriteFile = 1;
        public const byte WarningOverwriteDestination = 2;
        public const byte Yes = 3;
        public const byte No = 4;
        public const byte Ok = 5;
        public const byte Cancel = 6;
        public const byte Skip = 7;
        public const byte Repeat = 8;
        public const byte Abort = 9;
        
    }
}
