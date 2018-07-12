﻿using System;
using System.Collections.Generic;

namespace WorkspaceServer.Models.SingatureHelp
{
    public class SignatureHelpResponse
    {
        private IEnumerable<SignatureHelpItem> signatures ;

        public IEnumerable<SignatureHelpItem> Signatures
        {
            get => signatures ?? (signatures = Array.Empty<SignatureHelpItem>());
            set => signatures  = value;
        }

        public int ActiveSignature { get; set; }

        public int ActiveParameter { get; set; }
    }
}