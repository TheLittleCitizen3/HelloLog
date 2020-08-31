using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloLog
{
    public class RunLog
    {
        public void RunLogic()
        {
            try
            {
                Random rnd = new Random();
                int n = rnd.Next(4);
                switch (n)
                {
                    case 0:
                        Log.Information("Hello World!");
                        break;
                    case 1:
                        Log.Warning("Hello World!");
                        break;
                    case 2:
                        Log.Debug("Hello World!");
                        break;
                    case 3:
                        Log.Error("Hello World!");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Fatal("Hello World?" + ex.Message);
                throw;
            }
        }
    }
}
