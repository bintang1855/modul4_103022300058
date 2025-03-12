using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300058
{
    public class FanLaptop
    {
        public enum LaptopState { Quiet,Balanced,Performace,Turbo};
        public enum Trigger { Mode_Down,Mode_Up,Turbo_Shortcut};

        public LaptopState currentState = LaptopState.Quiet;

        public class Transisi {
            public LaptopState prevState;
            public LaptopState nextState;
            public Trigger trigger;
            public Transisi(LaptopState prevState, LaptopState nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        } 

        Transisi[] transisi = {
            new Transisi(LaptopState.Quiet,LaptopState.Balanced,Trigger.Mode_Up),
            new Transisi(LaptopState.Balanced,LaptopState.Performace,Trigger.Mode_Up),
            new Transisi(LaptopState.Performace,LaptopState.Turbo,Trigger.Mode_Up),
            new Transisi(LaptopState.Quiet,LaptopState.Turbo,Trigger.Turbo_Shortcut),
            new Transisi(LaptopState.Turbo,LaptopState.Quiet,Trigger.Turbo_Shortcut),
            new Transisi(LaptopState.Turbo,LaptopState.Performace,Trigger.Mode_Down),
            new Transisi(LaptopState.Performace,LaptopState.Balanced,Trigger.Mode_Down),
            new Transisi(LaptopState.Balanced,LaptopState.Quiet,Trigger.Mode_Down)
        };

        

        public LaptopState getNextState(LaptopState prevState, Trigger trigger)
        {
            LaptopState nextState = prevState;
            for (int i = 0; i < transisi.Length; i++)
            {
                if (transisi[i].prevState == prevState && transisi[i].trigger == trigger)
                    nextState = transisi[i].nextState;
            }
            return nextState;
        }

        public void activateTrigger(Trigger trigger)
        {
            Console.Write("Fan " + currentState );
            LaptopState nextState = getNextState(currentState, trigger);
            currentState = nextState;
            Console.WriteLine(" berubah menjadi " + currentState);
        }




    }
}
