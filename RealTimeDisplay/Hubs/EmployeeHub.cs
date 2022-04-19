using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNetCore.SignalR;
using HubMethodNameAttribute = Microsoft.AspNet.SignalR.Hubs.HubMethodNameAttribute;

namespace RealTimeDisplay.Hubs
{

    [HubName("employee")]
    public class EmployeeHub: Hub
    {
        //[HubMethodName("sendemployee")]
        //public void SendEmployee(string name, int salary)
        //{
        //    Clients.All.SendAsync("newemp",name, salary);
        //}

        [HubMethodName("sendemployee")]
        public void SendEmployee(string fname, string lname,
            string mobile,string salary, string address)
        {
            Clients.All.SendAsync("newemp", fname,  lname,
                mobile, salary, address);
        }
    }
}
