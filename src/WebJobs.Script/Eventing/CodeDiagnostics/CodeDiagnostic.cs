// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using Microsoft.CodeAnalysis;

namespace Microsoft.Azure.WebJobs.Script.Eventing
{
    public sealed class CodeDiagnostic
    {
        public string FileName { get; set; }

        public string Code { get; set; }

        public string Message { get; set; }

        public int StartLine { get; set; }

        public int EndLine { get; set; }

        public int StartColumn { get; set; }

        public int EndColumn { get; set; }

        public DiagnosticSeverity Severity { get; set; }
    }
}
