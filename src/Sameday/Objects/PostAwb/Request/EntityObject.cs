using System;
using System.Collections.Generic;

namespace Sameday.Objects.PostAwb.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class EntityObject
    {
        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CompanyEntityObject Company { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual IDictionary<string, string> GetFields()
        {
            throw new NotImplementedException();
        }
    }
}
