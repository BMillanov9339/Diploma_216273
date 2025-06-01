using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

//using diploma_216273.Modules;

namespace diploma_216273.Services
{
    public class Timers
    {
        private Timer _timer;
        private volatile bool _timerFlag;
        

        public Timers()
        {
            _timer = new Timer(1000); 
            _timer.Elapsed += (s, e) => _timerFlag = true;
            _timer.AutoReset = true;
            _timer.Start();
        }

        public bool getTimerFlag()
        {
            if (_timerFlag)
            {
                _timerFlag = false;
                return true;
            }
            
            return false;
            
        }

        
        public void Stop()
        {
            _timer.Stop();
            _timer.Dispose();
        }
    }
}
