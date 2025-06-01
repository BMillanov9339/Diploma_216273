using System.Timers;

namespace diploma_216273.Services
{
    //Вътрешен таймер, контролира процесите и флаговете

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
