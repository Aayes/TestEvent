using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace 测试委托
{
    class Task
    {
        public Task()
        {
            st.Start();
        }
        public Stopwatch st = new Stopwatch();
        public event EventHandler<EventArgs> EventTxFarms;
        private void TxFarmsEvent(int id, byte[] dat, int dlc, long time)
        {
            if (EventTxFarms != null)
            {
                EventArgs e_args = new EventArgs();
                EventTxFarms(this, e_args);
            }
        }
        public void start()
        {
            st.Restart();
            TxFarmsEvent(0x7df, new byte[8], 8, 10);
        }
    }
}
