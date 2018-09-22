// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using BitcoinLib.Responses.Bridges;
using BitcoinLib.Responses.SharedComponents;
using System.Collections.Generic;

namespace BitcoinLib.Responses
{
    public class GetRawTransactionResponse : ITransactionResponse
    {
        public string TxId { get; set; }
        public string Hash { set; get; }
        public int Version { set; get; }
        public int Size { set; get; }
        public int VSize { set; get; }
        public string Hex { get; set; }
        public uint LockTime { get; set; }
        public List<Vin> Vin { get; set; }
        public List<Vout> Vout { get; set; }
        public string BlockHash { get; set; }
        public int Confirmations { get; set; }
        public uint Time { get; set; }
        public uint BlockTime { get; set; }
    }
}