﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.Text;

namespace Balakin.VSOutputEnhancer.Parsers {
    public interface IParser<T> where T : ParsedData {
        Boolean TryParse(SnapshotSpan span, out T result);
    }
}
