
using System.Text.Json.Serialization;

namespace Data.Business.Data
{

    public static class Requests
    {


        public class BookingToolRequest
        {
            [JsonPropertyName("customer_name")]
            public string CustomerName { get; set; } = string.Empty;

            [JsonPropertyName("datetime")]
            public DateTime Datetime { get; set; } = DateTime.MinValue;

            [JsonPropertyName("email")]
            public string? Email { get; set; }

            [JsonPropertyName("phone_number")]
            public string? PhoneNumber { get; set; }
        }

        public class RetellWebhookEnvelope
        {
            [JsonPropertyName("event")]
            public string Event { get; set; } = string.Empty;

            [JsonPropertyName("call")]
            public RetellWebhookPayload Call { get; set; } = new RetellWebhookPayload();
        }
        public class RetellWebhookPayload
        {

            [JsonPropertyName("call_id")]
            public string CallId { get; set; } = string.Empty;

            [JsonPropertyName("call_status")]
            public string CallStatus { get; set; } = string.Empty; // "registered", "in_progress", "completed"

            [JsonPropertyName("metadata")]
            public CallMetadata Metadata { get; set; } = new CallMetadata();

            [JsonPropertyName("call_analysis")]
            public CallAnalysis Analysis { get; set; } = new CallAnalysis();

            [JsonPropertyName("disconnection_reason")]
            public string DisconnectionReason { get; set; } = string.Empty; // "agent_hangup", "user_hangup", "call_failed"

            // (يمكنك إضافة باقي الحقول من الـ JSON مثل transcript, recording_url إذا احتجتها)
        }

        /// <summary>
        /// (قسم التحليل)
        /// </summary>
        public class CallAnalysis
        {
            [JsonPropertyName("call_summary")]
            public string CallSummary { get; set; } = string.Empty;

            [JsonPropertyName("in_voicemail")]
            public bool InVoicemail { get; set; }

            [JsonPropertyName("user_sentiment")]
            public string UserSentiment { get; set; } = string.Empty; 

            [JsonPropertyName("call_successful")]
            public bool CallSuccessful { get; set; } 

        }


        public class ToolResult
        {
            [JsonPropertyName("tool_call_id")]
            public string ToolCallId { get; set; } = string.Empty;

            [JsonPropertyName("Name")]
            public string Name { get; set; } = string.Empty;

            [JsonPropertyName("arguments")]
            public string Arguments { get; set; } = string.Empty;
        }


        public class CallMetadata
        {
            [JsonPropertyName("our_customer_id")]
            public long OurCustomerId { get; set; }
        }
        public class RetellFunctionPayload
        {
            [JsonPropertyName("call")]
            public RetellCallObject Call { get; set; } = new RetellCallObject();

            [JsonPropertyName("args")]
            public BookingToolRequest Args { get; set; } = new BookingToolRequest();
        }
        public class RetellCallObject
        {
            [JsonPropertyName("call_id")]
            public string CallId { get; set; } = string.Empty;

            [JsonPropertyName("metadata")]
            public CallMetadata Metadata { get; set; } = new CallMetadata();
        }
        
        public class CreateCustomerRequest
        {
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            [JsonPropertyName("phoneNumber")]
            public string phoneNumber { get; set; } = string.Empty;

            [JsonPropertyName("email")]
            public string Email { get; set; } = string.Empty;
        }
        public class BookingRequest
        {
            public string ProspectName { get; set; } = string.Empty;
            public string? ProspectEmail { get; set; }
            public string? ProspectPhone { get; set; }
            public DateTime AppointmentTime { get; set; }
            public long CallId { get; set; } = 0;
        }

        public class SendEmailRequests
        {
            public int CustomerId { get; set; }
            public string Subject { get; set; } = string.Empty;
            public string Body { get; set; } = string.Empty;
        }
    }
}