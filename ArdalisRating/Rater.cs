using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public class Rater
    {
        protected readonly RatingEngine _engine;
        protected readonly ConsoleLogger _logger;

        public Rater(RatingEngine engine, ConsoleLogger logger)
        {
            this._engine = engine;
            this._logger = logger;
        }
        public virtual void Rate(Policy policy) { }
    }
}
