using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{   
    /// <summary>
    /// 
    /// </summary>
   public class Aquarium : IHabitable
    {
        private int volume; 
        private float temperature;
        private float lightLevel;
        private int oxigenLevel;
        private bool isSalt;
        private enum Types { Fish, Shellfish, Seaweed };
        private List<Fish> listWithfish;
        private List<Shellfish> listWithShellfish;
        private List<Seaweed> listWithSeaweeds;
       // private Hashtable residents;
        #region Constructors
        public Aquarium(int aVolume, bool aIsSalt) {
            this.volume = aVolume;
            this.IsSalt = aIsSalt;
            createCollections();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aVolume">The volume of aquarium.</param>
        /// <param name="aIsSalt">Freshwater or saltwater?</param>
        /// <param name="aTtemperature">Шhe temperature of the aquarium</param>
        /// <param name="aLightLevel">Light level between 0 and 1.</param>
        /// <param name="aOxigen"> The oxigen level</param>
        public Aquarium(int aVolume, bool aIsSalt, float aTtemperature, float aLightLevel,int aOxigen) {
            this.volume = aVolume;
            this.IsSalt = aIsSalt;
            this.Temperature = aTtemperature;
            this.LightLevel = aLightLevel;
            this.OxigenLevel = aOxigen;
            createCollections();
        }
        #endregion
        private void createCollections()
        {
            listWithfish = new List<Fish>();
            listWithShellfish = new List<Shellfish>();
            listWithSeaweeds = new List<Seaweed>();
        }
        /// <summary>
        /// Adds organism into correct arraylist.
        /// </summary>
        /// <param name="organism"></param>
        public  void addOrganism(AquaticOrganism organism) {
            switch (organism.GetType().BaseType.Name)
            {
                case "Fish":
                    listWithfish.Add((Fish)organism); 
                    Console.WriteLine("Fish added succesfully!");
                    break;
                case "Shellfish":
                    listWithShellfish.Add((Shellfish)organism);
                    Console.WriteLine("Shellfish added..");
                    break;
                case "Seaweed":
                    listWithSeaweeds.Add((Seaweed)organism);
                    Console.WriteLine("Seaweed added..");
                    break;
                default:
                    break;
            }
        }
        public float Temperature
        {
            get
            {
                return temperature;
            }

            set
            {
                temperature = value;
            }
        }

        public float LightLevel
        {
            get
            {
                return lightLevel;
            }

            set
            {
                lightLevel = value;
            }
        }

        public int OxigenLevel
        {
            get
            {
                return oxigenLevel;
            }

            set
            {
                oxigenLevel = value;
            }
        }

        public bool IsSalt
        {
            get
            {
                return isSalt;
            }

            set
            {
                isSalt = value;
            }
        }
        #region Getters for Arrays with residents
        internal List<Fish> ListWithfish
        {
            get
            {
                return listWithfish;
            }            
        }

        internal List<Shellfish> ListWithShellfish
        {
            get
            {
                return listWithShellfish;
            }             
        }

        internal List<Seaweed> ListWithSeaweeds
        {
            get
            {
                return listWithSeaweeds;
            }
        }
        #endregion
        /// <summary>
        /// Decrease temp in water tank.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Decreased value</returns>
        public float decreaseTemp( float value )
        {
            if (value > 0) {
            Temperature-=value;
            }
            return Temperature;
        }
        /// <summary>
        /// Increase temperature in water tank.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float increaseTemp( float value )
        {
            if (value > 0)
            {
                Temperature += value;
            }
            return Temperature;
        }
        /// <summary>
        /// Decrease light in the tank.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float decreaseLight( float value )
        {
            if (value > 0)
            {
                LightLevel -= value;
            }
            return LightLevel;
        }
        /// <summary>
        /// Increase light in the tank.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float increaseLight( float value )
        {
            if (value > 0)
            {
                LightLevel += value;
            }
            return LightLevel;
        }
        /// <summary>
        /// Increase oxigen level in water tank.
        /// </summary>
        /// <param name="oxigenUnit"></param>
        /// <returns></returns>
        public int increaseOxigenLevel( int oxigenUnit )
        {
            if (oxigenUnit > 0) {
                OxigenLevel += oxigenUnit;
            }
            return OxigenLevel;
        }
        /// <summary>
        /// Decrease oxigen level in water tank.
        /// </summary>
        /// <param name="oxigenUnit"></param>
        /// <returns></returns>
        public int decreaseOxigenLevel( int oxigenUnit )
        {
            if (oxigenUnit > 0)
            {
                OxigenLevel -= oxigenUnit;
            }
            return OxigenLevel;
        }         
    }
}
