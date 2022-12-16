using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillfactory_10_FinalTask
{
    public class Worker1: IWorker
    {
        ILogger Logger { get;}
        public Worker1(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Калькулятор начал свою работу");      
        }

        public void Error()
        {
            Logger.Error("В работе калькулятора допущена ошибка");
        }
    }
}
