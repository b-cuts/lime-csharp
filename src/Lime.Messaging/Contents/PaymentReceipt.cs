﻿using System;
using System.Runtime.Serialization;
using Lime.Protocol;

namespace Lime.Messaging.Contents
{
    /// <summary>
    /// Defines a receipt for an invoice payment.
    /// </summary>
    /// <seealso cref="Lime.Protocol.Document" />
    [DataContract(Namespace = "http://limeprotocol.org/2014")]
    public class PaymentReceipt : Document
    {
        public const string MIME_TYPE = "application/vnd.lime.payment-receipt+json";

        public const string METHOD_KEY = "method";        
        public const string CODE_KEY = "code";
        public const string PAID_ON_KEY = "paidOn";
        public const string CURRENCY_KEY = "currency";
        public const string TAXES_KEY = "taxes";
        public const string TOTAL_KEY = "total";
        public const string ITEMS_KEY = "items";

        public static readonly MediaType MediaType = MediaType.Parse(MIME_TYPE);

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentReceipt"/> class.
        /// </summary>
        public PaymentReceipt() 
            : base(MediaType)
        {
        }

        /// <summary>
        /// Gets or sets the payment method used in the payment.
        /// </summary>
        /// <example>Credit card</example>
        /// <example>Cash</example>
        /// <value>
        /// The payment method.
        /// </value>
        [DataMember(Name = METHOD_KEY)]
        public PaymentMethod Method { get; set; }

        /// <summary>
        /// Gets or sets the payment transaction code generated by the processor.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        [DataMember(Name = CODE_KEY)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the payment date.
        /// </summary>
        /// <value>
        /// The creation.
        /// </value>
        [DataMember(Name = PAID_ON_KEY)]
        public DateTimeOffset? PaidOn { get; set; }

        /// <summary>
        /// Gets or sets the receipt currency code related to the values.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        [DataMember(Name = CURRENCY_KEY)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the receipt total taxes value.
        /// </summary>
        /// <value>
        /// The taxes.
        /// </value>
        [DataMember(Name = TAXES_KEY)]
        public decimal? Taxes { get; set; }

        /// <summary>
        /// Gets or sets the receipt total value, including taxes.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        [DataMember(Name = TOTAL_KEY)]
        public decimal Total { get; set; }

        /// <summary>
        /// Gets or sets the invoice items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [DataMember(Name = ITEMS_KEY)]
        public InvoiceItem[] Items { get; set; }
    }
}
