using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    interface IHabitable
    {        
      float increaseTemp(float value);
      float decreaseTemp(float value);

      float increaseLight(float value);
      float decreaseLight(float value);

      int increaseOxigenLevel(int oxigenUnit);
      int decreaseOxigenLevel(int oxigenUnit);
    }
}
