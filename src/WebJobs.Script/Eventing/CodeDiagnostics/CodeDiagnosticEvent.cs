// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Script.Eventing
{
    public sealed class CodeDiagnosticEvent : ScriptEvent
    {
        public CodeDiagnosticEvent(string functionName, ImmutableArray<CodeDiagnostic> diagnostics, string source) : base(nameof(CodeDiagnosticEvent), source)
        {
            FunctionName = functionName;
            Diagnostics = diagnostics;
        }

        public string FunctionName { get; }

        public ImmutableArray<CodeDiagnostic> Diagnostics { get; }
    }
}
