﻿using Microsoft.VisualStudio.Text.Tagging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxMark.EditorClassifier
{
    public class TxMarkKeywordTag : TextMarkerTag
    {
        public TxMarkKeywordTag()
            : base("MarkerFormatDefinition/TxMarkKeywordFormatDefinition")
        {

        }
    }
}
