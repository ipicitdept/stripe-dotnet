namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebitOptions AuBecsDebit { get; set; }

        [JsonProperty("billing_details")]
        public BillingDetailsOptions BillingDetails { get; set; }

        [JsonProperty("card")]
        public todo-thingy Card { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("fpx")]
        public PaymentMethodFpxOptions Fpx { get; set; }

        [JsonProperty("ideal")]
        public PaymentMethodIdealOptions Ideal { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitOptions SepaDebit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
