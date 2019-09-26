﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seq2SeqSharp.Tools;
using System.IO;

namespace Seq2SeqSharp
{
    public interface IEncoder
    {
        IWeightTensor Encode(IWeightTensor rawInput, IComputeGraph g);
        void Reset(IWeightFactory weightFactory);
        List<IWeightTensor> GetParams();
        void Save(Stream stream);
        void Load(Stream stream);
    }
}
