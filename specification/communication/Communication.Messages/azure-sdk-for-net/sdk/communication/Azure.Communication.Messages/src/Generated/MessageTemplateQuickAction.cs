// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.Messages
{
    /// <summary> The message template's quick action value information. </summary>
    public partial class MessageTemplateQuickAction : MessageTemplateValue
    {
        /// <summary> Initializes a new instance of <see cref="MessageTemplateQuickAction"/>. </summary>
        /// <param name="name"> Name of the Template value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public MessageTemplateQuickAction(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Kind = "quickAction";
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplateQuickAction"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="name"> Name of the Template value. </param>
        /// <param name="text"> The [Optional] quick action text. </param>
        /// <param name="payload"> The [Optional] quick action payload. </param>
        internal MessageTemplateQuickAction(string kind, string name, string text, string payload) : base(kind, name)
        {
            Text = text;
            Payload = payload;
        }

        /// <summary> The [Optional] quick action text. </summary>
        public string Text { get; set; }
        /// <summary> The [Optional] quick action payload. </summary>
        public string Payload { get; set; }
    }
}