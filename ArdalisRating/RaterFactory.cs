using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
        {
            try
            {
                var rater = (Rater)Activator.CreateInstance(Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"), new object[] { engine, engine.Logger });
                return rater;
            }
            catch { 
                return null;
            }

            #region using switch
            //switch (policy.Type)
            //{
            //    case PolicyType.Auto:
            //        return new AutoPolicyRater(engine, engine.Logger);

            //    case PolicyType.Land:
            //        return new LandPolicyRater(engine, engine.Logger);

            //    case PolicyType.Life:
            //        return new LifePolicyRater(engine, engine.Logger);

            //    default:
            //        //TODO: Use NULL object pattern.
            //        engine.Logger.Log("Unknown policy type");
            //        return null;

            //} 
            #endregion
        }
    }
}
