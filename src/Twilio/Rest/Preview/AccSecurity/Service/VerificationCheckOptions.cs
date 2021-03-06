/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.AccSecurity.Service 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// challenge a specific Verification Check.
    /// </summary>
    public class CreateVerificationCheckOptions : IOptions<VerificationCheckResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The verification string
        /// </summary>
        public string Code { get; }
        /// <summary>
        /// To phonenumber
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Construct a new CreateVerificationCheckOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="code"> The verification string </param>
        public CreateVerificationCheckOptions(string pathServiceSid, string code)
        {
            PathServiceSid = pathServiceSid;
            Code = code;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Code != null)
            {
                p.Add(new KeyValuePair<string, string>("Code", Code));
            }

            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To));
            }

            return p;
        }
    }

}