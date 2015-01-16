using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5Threads
{
    public class House
    {
        private Queue<Car> q1;
        private Queue<Car> q2;
        private Queue<Car> q3;
        private Queue<Car> q4;

        private Car[] house;

        private ListBox lstbQ1;
        private ListBox lstbQ2;
        private ListBox lstbQ3;
        private ListBox lstbQ4;
        private ListBox lstbParked;
        private ListBox lstbExit;

        private Label lblQ1;
        private Label lblQ2;
        private Label lblQ3;
        private Label lblQ4;
        private Label lblParked;

        private object lockObj;
        private object lockUpdate;

        private Random rnd;

        private int count;
        private bool houseFull;
        private bool guiBusy;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public int Size
        {
            get { return house.Length; }
        }

        public House(   ListBox lstbQ1, ListBox lstbQ2, ListBox lstbQ3, ListBox lstbQ4, 
                        ListBox lstbParked, ListBox lstbExit, Label lblQ1, Label lblQ2, 
                        Label lblQ3, Label lblQ4, Label lblParked)
        {
            house = new Car[5];

            q1 = new Queue<Car>();
            q2 = new Queue<Car>();
            q3 = new Queue<Car>();
            q4 = new Queue<Car>();

            this.lstbQ1 = lstbQ1;
            this.lstbQ2 = lstbQ2;
            this.lstbQ3 = lstbQ3;
            this.lstbQ4 = lstbQ4;
            this.lstbParked = lstbParked;
            this.lstbExit = lstbExit;

            this.lblQ1 = lblQ1;
            this.lblQ2 = lblQ2;
            this.lblQ3 = lblQ3;
            this.lblQ4 = lblQ4;
            this.lblParked = lblParked;

            lockObj = new object();
            lockUpdate = new object();

            rnd = new Random();

            houseFull = false;
            guiBusy = false;
        }

        public void AddToQ1(Car c)
        {
            if (q1.Count < 50)
            {
                lock (lockObj)
                {
                    q1.Enqueue(c);
                    UpdateQueue(1, string.Format("{0} {1} queued!", c.Color.ToString(), c.Brand.ToString()));
                    UpdateQueue1();
                }
            }
        }
        public void AddToQ2(Car c)
        {
            if (q2.Count < 50)
            {
                lock (lockObj)
                {
                    q2.Enqueue(c);
                    UpdateQueue(2, string.Format("{0} {1} queued!", c.Color.ToString(), c.Brand.ToString()));
                    UpdateQueue2();
                }
            }
        }
        public void AddToQ3(Car c)
        {
            if (q3.Count < 50)
            {
                lock (lockObj)
                {
                    q3.Enqueue(c);
                    UpdateQueue(3, string.Format("{0} {1} queued!", c.Color.ToString(), c.Brand.ToString()));
                    UpdateQueue3();
                }
            }
        }
        public void AddToQ4(Car c)
        {
            if (q4.Count < 50)
            {
                lock (lockObj)
                {
                    q4.Enqueue(c);
                    UpdateQueue(4, string.Format("{0} {1} queued!", c.Color.ToString(), c.Brand.ToString()));
                    UpdateQueue4();
                }
            }
        }

        public void CheckHouse()
        {
            for (int i = 0; i < house.Length; i++)
            {
                lock (lockObj)
                {
                    if (house[i] == null)
                        return;
                    if (!CheckCar(house[i]))
                    {
                        AddToExit(string.Format("{0}, {1}: Spot {2} free!", house[i].Brand.ToString(), house[i].Color.ToString(), i.ToString()));
                        house[i] = null;
                        count--;
                        houseFull = false;
                        UpdateParked();
                        Monitor.Pulse(lockObj);
                    }
                }
            }
        }

        private bool CheckCar(Car c)
        {
            int result = DateTime.Compare(c.ParkingTime, DateTime.Now);

            if (result <= 0)
                return false;
            else
                return true;
        }

        public void ParkCar(int q)
        {
            switch (q)
            {
                case 1:
                    lock (lockObj)
                    {
                        if (q1.Count == 0)
                            return;
                        Car c = q1.Dequeue();
                        while (houseFull)
                            Monitor.Wait(lockObj);
                        int spot;
                        if (FindSpot(out spot))
                        {
                            c.ParkingTime = DateTime.Now.AddSeconds(rnd.Next(1, 24));
                            house[spot] = c;
                            AddToParked(string.Format("{0}, {1}: Spot: {2}!", c.Brand.ToString(), c.Color.ToString(), spot.ToString()));
                            RemoveFirstQ1();
                            UpdateQueue1();
                            count++;
                            UpdateParked();
                        } 
                    }
                    break;
                case 2:
                    lock (lockObj)
                    {
                        if (q2.Count == 0)
                            return;
                        Car c = q2.Dequeue();
                        while (houseFull)
                            Monitor.Wait(lockObj);
                        int spot;
                        if (FindSpot(out spot))
                        {
                            c.ParkingTime = DateTime.Now.AddSeconds(rnd.Next(1, 24));
                            house[spot] = c;
                            AddToParked(string.Format("{0}, {1}: Spot: {2}!", c.Brand.ToString(), c.Color.ToString(), spot.ToString()));
                            RemoveFirstQ2();
                            UpdateQueue2();
                            count++;
                            UpdateParked();
                        } 
                    }
                    break;
                case 3:
                    lock (lockObj)
                    {
                        if (q3.Count == 0)
                            return;
                        Car c = q3.Dequeue();
                        while (houseFull)
                            Monitor.Wait(lockObj);
                        int spot;
                        if (FindSpot(out spot))
                        {
                            c.ParkingTime = DateTime.Now.AddSeconds(rnd.Next(1, 24));
                            house[spot] = c;
                            AddToParked(string.Format("{0}, {1}: Spot: {2}!", c.Brand.ToString(), c.Color.ToString(), spot.ToString()));
                            RemoveFirstQ3();
                            UpdateQueue3();
                            count++;
                            UpdateParked();
                        } 
                    }
                    break;
                case 4:
                    lock (lockObj)
                    {
                        if (q4.Count == 0)
                            return;
                        Car c = q4.Dequeue();
                        while (houseFull)
                            Monitor.Wait(lockObj);
                        int spot;
                        if (FindSpot(out spot))
                        {
                            c.ParkingTime = DateTime.Now.AddSeconds(rnd.Next(1, 24));
                            house[spot] = c;
                            AddToParked(string.Format("{0}, {1}: Spot: {2}!", c.Brand.ToString(), c.Color.ToString(), spot.ToString()));
                            RemoveFirstQ4();
                            UpdateQueue4();
                            count++;
                            UpdateParked();
                        } 
                    }
                    break;
                default:
                    break;
            }
            
        }

        private bool FindSpot(out int i)
        {
            for (i = 0; i < house.Length; i++)
            {
                lock (lockObj)
                {
                    if (house[i] == null)
                        return true;
                }
            }
            lock (lockObj)
            {
                houseFull = true;
            }
            return false;
        }

        #region GUI updates

        private void AddToParked(string s)
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lstbParked.InvokeRequired)
                {
                    lstbParked.Invoke(new MethodInvoker(delegate
                    {
                        if (lstbParked.Items.Count >= 20)
                            lstbParked.Items.RemoveAt(0);
                        lstbParked.Items.Add(s);
                    }));
                }
                else
                {
                    if (lstbParked.Items.Count >= 20)
                        lstbParked.Items.RemoveAt(0);
                    lstbParked.Items.Add(s);
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        private void AddToExit(string s)
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lstbExit.InvokeRequired)
                {
                    lstbExit.Invoke(new MethodInvoker(delegate
                    {
                        if (lstbExit.Items.Count >= 20)
                            lstbExit.Items.RemoveAt(0);
                        lstbExit.Items.Add(s);
                    }));
                }
                else
                {
                    if (lstbExit.Items.Count >= 20)
                        lstbExit.Items.RemoveAt(0);
                    lstbExit.Items.Add(s);
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        private void UpdateQueue1()
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lblQ1.InvokeRequired)
                {
                    lblQ1.Invoke(new MethodInvoker(delegate
                    {
                        lblQ1.Text = q1.Count.ToString();
                    }));
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        private void UpdateQueue2()
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lblQ2.InvokeRequired)
                {
                    lblQ2.Invoke(new MethodInvoker(delegate
                    {
                        lblQ2.Text = q2.Count.ToString();
                    }));
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        private void UpdateQueue3()
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lblQ3.InvokeRequired)
                {
                    lblQ3.Invoke(new MethodInvoker(delegate
                    {
                        lblQ3.Text = q3.Count.ToString();
                    }));
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        private void UpdateQueue4()
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lblQ4.InvokeRequired)
                {
                    lblQ4.Invoke(new MethodInvoker(delegate
                    {
                        lblQ4.Text = q4.Count.ToString();
                    }));
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        private void UpdateQueue(int i, string s)
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lstbQ1.InvokeRequired)
                {
                    lstbQ1.Invoke(new MethodInvoker(delegate
                    {
                        switch (i)
                        {
                            case 1:
                                lstbQ1.Items.Add(s);
                                break;
                            case 2:
                                lstbQ2.Items.Add(s);
                                break;
                            case 3:
                                lstbQ3.Items.Add(s);
                                break;
                            case 4:
                                lstbQ4.Items.Add(s);
                                break;
                            default:
                                break;
                        }
                    }));
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        private void UpdateParked()
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lblParked.InvokeRequired)
                {
                    lblParked.Invoke(new MethodInvoker(delegate
                    {
                        lblParked.Text = (house.Length - count).ToString();
                    }));
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        private void RemoveFirstQ1()
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lblQ1.InvokeRequired)
                {
                    lblQ1.Invoke(new MethodInvoker(delegate
                    {
                        if (lstbQ1.Items.Count > 0)
                            lstbQ1.Items.RemoveAt(0);
                    }));
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        private void RemoveFirstQ2()
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lblQ2.InvokeRequired)
                {
                    lblQ2.Invoke(new MethodInvoker(delegate
                    {
                        if (lstbQ2.Items.Count > 0)
                            lstbQ2.Items.RemoveAt(0);
                    }));
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        private void RemoveFirstQ3()
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lblQ3.InvokeRequired)
                {
                    lblQ3.Invoke(new MethodInvoker(delegate
                    {
                        if (lstbQ3.Items.Count > 0)
                            lstbQ3.Items.RemoveAt(0);
                    }));
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        private void RemoveFirstQ4()
        {
            lock (lockUpdate)
            {
                while (guiBusy)
                    Monitor.Wait(lockUpdate);
                if (lblQ4.InvokeRequired)
                {
                    lblQ4.Invoke(new MethodInvoker(delegate
                    {
                        if (lstbQ4.Items.Count > 0)
                            lstbQ4.Items.RemoveAt(0);
                    }));
                }
                guiBusy = false;
                Monitor.Pulse(lockUpdate);
            }
        }

        #endregion
    }
}
