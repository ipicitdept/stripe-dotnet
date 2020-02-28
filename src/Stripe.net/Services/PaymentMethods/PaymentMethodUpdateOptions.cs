namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("billing_details")]
        public BillingDetailsOptions BillingDetails { get; set; }

        [JsonProperty("card")]
        public PaymentMethodCardOptions Card { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitOptions SepaDebit { get; set; }
    }
}
