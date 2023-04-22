using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Sealevel; 

namespace SensorInputsService
{
    public partial class InputsService : ServiceBase
    {
        //variables 
        SeaMAX sm = new SeaMAX();


        public InputsService()
        {
            InitializeComponent();
        }

        protected void WorkProcess()
        {
            int errno = sm.SDL_Initialize();
        }

        protected override void OnStart(string[] args)
        {
            Logger.WriteLog("Starting Service");
        }

        protected override void OnStop()
        {
            int errno = sm.SDL_Cleanup();
            Logger.WriteLog("Stopping Service");
        }
    }
}
