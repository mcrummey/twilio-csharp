/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// HostedNumberOrderResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Preview.HostedNumbers 
{

    public class HostedNumberOrderResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}

            public static readonly StatusEnum Received = new StatusEnum("received");
            public static readonly StatusEnum PendingVerification = new StatusEnum("pending-verification");
            public static readonly StatusEnum Verified = new StatusEnum("verified");
            public static readonly StatusEnum PendingLoa = new StatusEnum("pending-loa");
            public static readonly StatusEnum CarrierProcessing = new StatusEnum("carrier-processing");
            public static readonly StatusEnum Testing = new StatusEnum("testing");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum ActionRequired = new StatusEnum("action-required");
        }

        private static Request BuildFetchRequest(FetchHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/HostedNumbers/HostedNumberOrders/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch a specific HostedNumberOrder.
        /// </summary>
        ///
        /// <param name="options"> Fetch HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns> 
        public static HostedNumberOrderResource Fetch(FetchHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific HostedNumberOrder.
        /// </summary>
        ///
        /// <param name="options"> Fetch HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns> 
        public static async System.Threading.Tasks.Task<HostedNumberOrderResource> FetchAsync(FetchHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific HostedNumberOrder.
        /// </summary>
        ///
        /// <param name="pathSid"> HostedNumberOrder sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns> 
        public static HostedNumberOrderResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchHostedNumberOrderOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific HostedNumberOrder.
        /// </summary>
        ///
        /// <param name="pathSid"> HostedNumberOrder sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns> 
        public static async System.Threading.Tasks.Task<HostedNumberOrderResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchHostedNumberOrderOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Preview,
                "/HostedNumbers/HostedNumberOrders/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Cancel the HostedNumberOrder (only available when the status is in `received`).
        /// </summary>
        ///
        /// <param name="options"> Delete HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns> 
        public static bool Delete(DeleteHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Cancel the HostedNumberOrder (only available when the status is in `received`).
        /// </summary>
        ///
        /// <param name="options"> Delete HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Cancel the HostedNumberOrder (only available when the status is in `received`).
        /// </summary>
        ///
        /// <param name="pathSid"> HostedNumberOrder sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns> 
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteHostedNumberOrderOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Cancel the HostedNumberOrder (only available when the status is in `received`).
        /// </summary>
        ///
        /// <param name="pathSid"> HostedNumberOrder sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteHostedNumberOrderOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/HostedNumbers/HostedNumberOrders/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Updates a specific HostedNumberOrder.
        /// </summary>
        ///
        /// <param name="options"> Update HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns> 
        public static HostedNumberOrderResource Update(UpdateHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Updates a specific HostedNumberOrder.
        /// </summary>
        ///
        /// <param name="options"> Update HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns> 
        public static async System.Threading.Tasks.Task<HostedNumberOrderResource> UpdateAsync(UpdateHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Updates a specific HostedNumberOrder.
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> A human readable description of this resource. </param>
        /// <param name="uniqueName"> A unique, developer assigned name of this HostedNumberOrder. </param>
        /// <param name="email"> Email. </param>
        /// <param name="ccEmails"> A list of emails. </param>
        /// <param name="status"> The Status of this HostedNumberOrder. </param>
        /// <param name="verificationCode"> A verification code. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns> 
        public static HostedNumberOrderResource Update(string pathSid, string friendlyName = null, string uniqueName = null, string email = null, List<string> ccEmails = null, HostedNumberOrderResource.StatusEnum status = null, string verificationCode = null, ITwilioRestClient client = null)
        {
            var options = new UpdateHostedNumberOrderOptions(pathSid){FriendlyName = friendlyName, UniqueName = uniqueName, Email = email, CcEmails = ccEmails, Status = status, VerificationCode = verificationCode};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Updates a specific HostedNumberOrder.
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> A human readable description of this resource. </param>
        /// <param name="uniqueName"> A unique, developer assigned name of this HostedNumberOrder. </param>
        /// <param name="email"> Email. </param>
        /// <param name="ccEmails"> A list of emails. </param>
        /// <param name="status"> The Status of this HostedNumberOrder. </param>
        /// <param name="verificationCode"> A verification code. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns> 
        public static async System.Threading.Tasks.Task<HostedNumberOrderResource> UpdateAsync(string pathSid, string friendlyName = null, string uniqueName = null, string email = null, List<string> ccEmails = null, HostedNumberOrderResource.StatusEnum status = null, string verificationCode = null, ITwilioRestClient client = null)
        {
            var options = new UpdateHostedNumberOrderOptions(pathSid){FriendlyName = friendlyName, UniqueName = uniqueName, Email = email, CcEmails = ccEmails, Status = status, VerificationCode = verificationCode};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/HostedNumbers/HostedNumberOrders",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of HostedNumberOrders belonging to the account initiating the request.
        /// </summary>
        ///
        /// <param name="options"> Read HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns> 
        public static ResourceSet<HostedNumberOrderResource> Read(ReadHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<HostedNumberOrderResource>.FromJson("items", response.Content);
            return new ResourceSet<HostedNumberOrderResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of HostedNumberOrders belonging to the account initiating the request.
        /// </summary>
        ///
        /// <param name="options"> Read HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<HostedNumberOrderResource>> ReadAsync(ReadHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<HostedNumberOrderResource>.FromJson("items", response.Content);
            return new ResourceSet<HostedNumberOrderResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of HostedNumberOrders belonging to the account initiating the request.
        /// </summary>
        ///
        /// <param name="status"> The Status of this HostedNumberOrder. </param>
        /// <param name="phoneNumber"> An E164 formatted phone number. </param>
        /// <param name="incomingPhoneNumberSid"> IncomingPhoneNumber sid. </param>
        /// <param name="friendlyName"> A human readable description of this resource. </param>
        /// <param name="uniqueName"> A unique, developer assigned name of this HostedNumberOrder. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns> 
        public static ResourceSet<HostedNumberOrderResource> Read(HostedNumberOrderResource.StatusEnum status = null, Types.PhoneNumber phoneNumber = null, string incomingPhoneNumberSid = null, string friendlyName = null, string uniqueName = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadHostedNumberOrderOptions{Status = status, PhoneNumber = phoneNumber, IncomingPhoneNumberSid = incomingPhoneNumberSid, FriendlyName = friendlyName, UniqueName = uniqueName, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of HostedNumberOrders belonging to the account initiating the request.
        /// </summary>
        ///
        /// <param name="status"> The Status of this HostedNumberOrder. </param>
        /// <param name="phoneNumber"> An E164 formatted phone number. </param>
        /// <param name="incomingPhoneNumberSid"> IncomingPhoneNumber sid. </param>
        /// <param name="friendlyName"> A human readable description of this resource. </param>
        /// <param name="uniqueName"> A unique, developer assigned name of this HostedNumberOrder. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<HostedNumberOrderResource>> ReadAsync(HostedNumberOrderResource.StatusEnum status = null, Types.PhoneNumber phoneNumber = null, string incomingPhoneNumberSid = null, string friendlyName = null, string uniqueName = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadHostedNumberOrderOptions{Status = status, PhoneNumber = phoneNumber, IncomingPhoneNumberSid = incomingPhoneNumberSid, FriendlyName = friendlyName, UniqueName = uniqueName, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        ///
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<HostedNumberOrderResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<HostedNumberOrderResource>.FromJson("items", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<HostedNumberOrderResource> NextPage(Page<HostedNumberOrderResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<HostedNumberOrderResource>.FromJson("items", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<HostedNumberOrderResource> PreviousPage(Page<HostedNumberOrderResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<HostedNumberOrderResource>.FromJson("items", response.Content);
        }

        private static Request BuildCreateRequest(CreateHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/HostedNumbers/HostedNumberOrders",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Host a phone number's capability on Twilio's platform.
        /// </summary>
        ///
        /// <param name="options"> Create HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns> 
        public static HostedNumberOrderResource Create(CreateHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Host a phone number's capability on Twilio's platform.
        /// </summary>
        ///
        /// <param name="options"> Create HostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns> 
        public static async System.Threading.Tasks.Task<HostedNumberOrderResource> CreateAsync(CreateHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Host a phone number's capability on Twilio's platform.
        /// </summary>
        ///
        /// <param name="phoneNumber"> An E164 formatted phone number. </param>
        /// <param name="isoCountry"> ISO country code. </param>
        /// <param name="smsCapability"> Specify SMS capability to host. </param>
        /// <param name="accountSid"> Account Sid. </param>
        /// <param name="friendlyName"> A human readable description of this resource. </param>
        /// <param name="uniqueName"> A unique, developer assigned name of this HostedNumberOrder. </param>
        /// <param name="ccEmails"> A list of emails. </param>
        /// <param name="smsUrl"> SMS URL. </param>
        /// <param name="smsMethod"> SMS Method. </param>
        /// <param name="smsFallbackUrl"> SMS Fallback URL. </param>
        /// <param name="smsFallbackMethod"> SMS Fallback Method. </param>
        /// <param name="statusCallbackUrl"> Status Callback URL. </param>
        /// <param name="statusCallbackMethod"> Status Callback Method. </param>
        /// <param name="smsApplicationSid"> SMS Application Sid. </param>
        /// <param name="addressSid"> Address sid. </param>
        /// <param name="email"> Email. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HostedNumberOrder </returns> 
        public static HostedNumberOrderResource Create(Types.PhoneNumber phoneNumber, string isoCountry, bool? smsCapability, string accountSid = null, string friendlyName = null, string uniqueName = null, List<string> ccEmails = null, Uri smsUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsFallbackMethod = null, Uri statusCallbackUrl = null, Twilio.Http.HttpMethod statusCallbackMethod = null, string smsApplicationSid = null, string addressSid = null, string email = null, ITwilioRestClient client = null)
        {
            var options = new CreateHostedNumberOrderOptions(phoneNumber, isoCountry, smsCapability){AccountSid = accountSid, FriendlyName = friendlyName, UniqueName = uniqueName, CcEmails = ccEmails, SmsUrl = smsUrl, SmsMethod = smsMethod, SmsFallbackUrl = smsFallbackUrl, SmsFallbackMethod = smsFallbackMethod, StatusCallbackUrl = statusCallbackUrl, StatusCallbackMethod = statusCallbackMethod, SmsApplicationSid = smsApplicationSid, AddressSid = addressSid, Email = email};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Host a phone number's capability on Twilio's platform.
        /// </summary>
        ///
        /// <param name="phoneNumber"> An E164 formatted phone number. </param>
        /// <param name="isoCountry"> ISO country code. </param>
        /// <param name="smsCapability"> Specify SMS capability to host. </param>
        /// <param name="accountSid"> Account Sid. </param>
        /// <param name="friendlyName"> A human readable description of this resource. </param>
        /// <param name="uniqueName"> A unique, developer assigned name of this HostedNumberOrder. </param>
        /// <param name="ccEmails"> A list of emails. </param>
        /// <param name="smsUrl"> SMS URL. </param>
        /// <param name="smsMethod"> SMS Method. </param>
        /// <param name="smsFallbackUrl"> SMS Fallback URL. </param>
        /// <param name="smsFallbackMethod"> SMS Fallback Method. </param>
        /// <param name="statusCallbackUrl"> Status Callback URL. </param>
        /// <param name="statusCallbackMethod"> Status Callback Method. </param>
        /// <param name="smsApplicationSid"> SMS Application Sid. </param>
        /// <param name="addressSid"> Address sid. </param>
        /// <param name="email"> Email. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HostedNumberOrder </returns> 
        public static async System.Threading.Tasks.Task<HostedNumberOrderResource> CreateAsync(Types.PhoneNumber phoneNumber, string isoCountry, bool? smsCapability, string accountSid = null, string friendlyName = null, string uniqueName = null, List<string> ccEmails = null, Uri smsUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsFallbackMethod = null, Uri statusCallbackUrl = null, Twilio.Http.HttpMethod statusCallbackMethod = null, string smsApplicationSid = null, string addressSid = null, string email = null, ITwilioRestClient client = null)
        {
            var options = new CreateHostedNumberOrderOptions(phoneNumber, isoCountry, smsCapability){AccountSid = accountSid, FriendlyName = friendlyName, UniqueName = uniqueName, CcEmails = ccEmails, SmsUrl = smsUrl, SmsMethod = smsMethod, SmsFallbackUrl = smsFallbackUrl, SmsFallbackMethod = smsFallbackMethod, StatusCallbackUrl = statusCallbackUrl, StatusCallbackMethod = statusCallbackMethod, SmsApplicationSid = smsApplicationSid, AddressSid = addressSid, Email = email};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a HostedNumberOrderResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> HostedNumberOrderResource object represented by the provided JSON </returns> 
        public static HostedNumberOrderResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<HostedNumberOrderResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// HostedNumberOrder sid.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// IncomingPhoneNumber sid.
        /// </summary>
        [JsonProperty("incoming_phone_number_sid")]
        public string IncomingPhoneNumberSid { get; private set; }
        /// <summary>
        /// Address sid.
        /// </summary>
        [JsonProperty("address_sid")]
        public string AddressSid { get; private set; }
        /// <summary>
        /// LOA document sid.
        /// </summary>
        [JsonProperty("signing_document_sid")]
        public string SigningDocumentSid { get; private set; }
        /// <summary>
        /// An E164 formatted phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }
        /// <summary>
        /// A mapping of phone number capabilities.
        /// </summary>
        [JsonProperty("capabilities")]
        public PhoneNumberCapabilities Capabilities { get; private set; }
        /// <summary>
        /// A human readable description of this resource.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// A unique, developer assigned name of this HostedNumberOrder.
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The Status of this HostedNumberOrder.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HostedNumberOrderResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The date this HostedNumberOrder was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this HostedNumberOrder was updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The number of verification attempts made to verify ownership of the phone number.
        /// </summary>
        [JsonProperty("verification_attempts")]
        public int? VerificationAttempts { get; private set; }
        /// <summary>
        /// Email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; private set; }
        /// <summary>
        /// A list of emails.
        /// </summary>
        [JsonProperty("cc_emails")]
        public List<string> CcEmails { get; private set; }
        /// <summary>
        /// The URL of this HostedNumberOrder.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private HostedNumberOrderResource()
        {

        }
    }

}