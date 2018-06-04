using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //DECLARE FIELDS
        private int hunger;
        private int bored;
        private int tired;
        private string name;
        private bool hungerAlert;
        private bool boredAlert;
        private bool tiredAlert;
        //END DECLARE FIELDS

        //DECLARE PROPERTIES
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Bored
        {
            get { return this.bored; }
            set { this.bored = value; }
        }

        public int Tired
        {
            get { return this.tired; }
            set { this.tired = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public bool HungerAlert
        {
            get { return this.hungerAlert; }
            set { this.hungerAlert = value; }
        }

        public bool BoredAlert
        {
            get { return this.boredAlert; }
            set { this.boredAlert = value; }
        }

        public bool TiredAlert
        {
            get { return this.tiredAlert; }
            set { this.tiredAlert = value; }
        }
        //END DECLARE PROPERTIES

        //CONSTRUCTORS
        public VirtualPet()
        {
            //DEFAULT CONSTRUCTOR
        }

        //LOADED CONSTRUCTOR 
        public VirtualPet(int hunger, int bored, int tired, string name)
        {
            this.hunger = hunger;
            this.bored = bored;
            this.tired = tired;
            this.name = name;
        }
        //END LOADED CONSTRUCTOR

            //TICK METHOD
        public void Tick()
        {
            Hunger++;
            if (Hunger > 15)
            {
                HungerAlert(true);
            }
            else
            {
                HungerAlert(false);
            }
            Bored++;
            if (Bored > 5)
            {
                BoredAlert(true);
            }
            else
            {
                BoredAlert(false);
            }
            Tired++;
            if (Tired > 15)
            {
                TiredAlert(true);
            }
            else
            {
                TiredAlert(false);
            }

            bool HungerAlert(bool status)
            {
                hungerAlert = status;
                return hungerAlert;
            }
            bool BoredAlert(bool status)
            {
                boredAlert = status;
                return boredAlert;
            }
            bool TiredAlert(bool status)
            {
                tiredAlert = status;
                return tiredAlert;
            }

        }
        public int SetHunger(int num)
        {
            this.Hunger = num;
            return Hunger;
        }
        public int SetBored(int num)
        {
            this.Bored = num;
            return Bored;
        }
        public int SetTired(int num)
        {
            this.Tired = num;
            return Tired;
        }

    }
}
