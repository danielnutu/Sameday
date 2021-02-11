using System;
using System.Collections.Generic;

namespace Sameday.Objects.PostAwb.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class AwbRecipientEntityObject : EntityObject
    {
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IDictionary<string, string> GetFields()
        {
            throw new NotImplementedException();
        }
    }
}
