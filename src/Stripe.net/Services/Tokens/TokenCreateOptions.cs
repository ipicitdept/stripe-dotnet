namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TokenCreateOptions : BaseOptions
    {
        [JsonProperty("bank_account")]
        public TokenBankAccountOptions BankAccount { get; set; }

        [JsonProperty("card")]
        public todo-thingy Card { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("person")]
        public TokenPersonOptions Person { get; set; }

        [JsonProperty("pii")]
        public TokenPiiOptions Pii { get; set; }
    }
}
